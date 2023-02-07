using USER.BE;
using USER.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Manager
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioBE entity = new UsuarioBE();
            entity.nombre = txtNombre.Text;
            entity.apellido = txtApellido.Text;
            entity.edad = int.Parse(txtEdad.Text);
            entity.correo = txtCorreo.Text;

            //Genero genero = new Genero();
            //string genero = ddlGenero.SelectedValue;
            //string nacionalidad = ddlNacionalidad.SelectedValue;
            //string perfil = ddlPerfil.SelectedValue;

            //entity.idGenero = ddlGenero.SelectedValue;
            //entity.idNacionalidad = ddlNacionalidad.SelectedValue;
            //entity.idPerfil = ddlPerfil.SelectedValue;

            entity.idGenero = 1;
            entity.idNacionalidad = 1;
            entity.idPerfil = 1;

            bool rpta = false;
            UsuarioBL usuarioBL = new UsuarioBL();

            rpta = usuarioBL.Insertar(entity);
            
            if(rpta)
            {
                lblResultado.Text = "CORRECTO";
            }
             else
            {
                lblResultado.Text = "INCORRECTO";
            }

        }
    }
}