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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                UsuarioBE entity = new UsuarioBE();
                entity.codigo = "";
                entity.apellido = "";
                entity.idGenero = 0;
                entity.idNacionalidad = 0;
                entity.idPerfil = 0;
                this.ListarUsuario(entity);
                this.llenarCombobox();
            }
        }

        public void llenarCombobox()
        {
            UsuarioBL usuarioBL = new UsuarioBL();
            generos = usuarioBL.ListarGenero();
            List<string> gens = generos.Select(x => x.descripcion).ToList();
            foreach(string g in gens)
            {

            System.Diagnostics.Debug.WriteLine(g);
            }

            ddlGenero.DataSource = generos.Select(x => x.descripcion).ToList();
            perfiles = usuarioBL.ListarPerfiles();
            ddlPerfil.DataSource = perfiles.Select(x => x.descripcion);
            naciones = usuarioBL.ListarNacionalidades();
            ddlNacionalidad.DataSource = naciones.Select(x => x.descripcion);

            ddlGenero.DataSource = generos;
            ddlGenero.DataBind();
            ddlNacionalidad.DataSource = naciones;
            ddlNacionalidad.DataBind();
            ddlPerfil.DataSource = perfiles;
            ddlPerfil.DataBind();
        }

        public void ListarUsuario(UsuarioBE entity)
        {
            //this.hfDelete.Value = "0";

            UsuarioBL usuarioBL = new UsuarioBL();
            System.Diagnostics.Debug.WriteLine("_______________________________________________________________");
            System.Diagnostics.Debug.WriteLine(entity.codigo);
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
            entity.idGenero = 1;
            entity.idNacionalidad = 1;
            entity.idPerfil = 3;
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