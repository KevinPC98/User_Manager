using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using USER.BE;
using USER.BL;

namespace User_Manager
{
    public partial class Listar : System.Web.UI.Page
    {
        private List<Genero> generos = new List<Genero>();
        private List<Perfil> perfiles = new List<Perfil>();
        private List<Nacionalidad> naciones = new List<Nacionalidad>();

        //public List<Genero> Generos
        //{
        //    get { return generos; }
        //    set { generos = value; }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            this.llenarCombobox();

            if (!IsPostBack)
            {
                UsuarioBE entity = new UsuarioBE();
                entity.codigo = "";
                entity.apellido = "";
                entity.idGenero = 0;
                entity.idNacionalidad = 0;
                entity.idPerfil = 0;
                this.ListarUsuario(entity);

            }
        }

        public void llenarCombobox()
        {
            UsuarioBL usuarioBL = new UsuarioBL();

            generos = usuarioBL.ListarGenero();
            generos.Insert(0, new Genero { descripcion = "SELECCIONAR" });
            ddlGenero.DataSource = generos.Select(x => x.descripcion).ToList();
            perfiles = usuarioBL.ListarPerfiles();
            perfiles.Insert(0, new Perfil { descripcion = "SELECCIONAR" });
            ddlPerfil.DataSource = perfiles.Select(x => x.descripcion).ToList();
            naciones = usuarioBL.ListarNacionalidades();
            naciones.Insert(0, new Nacionalidad { descripcion = "SELECCIONAR" });
            ddlNacionalidad.DataSource = naciones.Select(x => x.descripcion).ToList();

            ddlGenero.DataBind();
            ddlNacionalidad.DataBind();
            ddlPerfil.DataBind();
        }

        public void ListarUsuario(UsuarioBE entity)
        {
            //this.hfDelete.Value = "0";

            UsuarioBL usuarioBL = new UsuarioBL();
            List<UsuarioBE> list = usuarioBL.Listar(entity);

            this.gvUsuario.DataSource = list;
            this.gvUsuario.DataBind();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //this.hfDelete.Value = "0";
            UsuarioBE entity = new UsuarioBE();
            entity.codigo = txtCodigo.Text;
            entity.apellido = txtApellido.Text;
            string genero = this.ddlGenero.SelectedValue;

            entity.idGenero = generos.Find(x => x.descripcion == genero).id;
            System.Diagnostics.Debug.WriteLine("idGenero: "+entity.idGenero);

            string nacionalidad = this.ddlNacionalidad.SelectedValue;
            entity.idNacionalidad = naciones.Find(x => x.descripcion == nacionalidad).id;
            string perfil = this.ddlPerfil.SelectedValue;
            entity.idPerfil = perfiles.Find(x => x.descripcion == perfil).id;
            this.ListarUsuario(entity);
        }

        protected void gvUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvUsuario_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvUsuario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}