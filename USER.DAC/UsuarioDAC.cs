using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USER.BE;

namespace USER.DAC
{
    public class UsuarioDAC : IUsuarioDAC
    {
        public bool Insertar(UsuarioBE entity)
        {
            try
            {
                using (var context = new UsuarioBEContext())
                {
                    context.entity.Add(entity);
                    context.SaveChanges();
                }
                return true;


            }
            catch (SqlException ex)
            {
                return false;
            }
            catch (Exception ex2)
            {
                return false;
            } 
        }

        public List<UsuarioBE> Listar(UsuarioBE entity)
        {
            List<UsuarioBE> list = new List<UsuarioBE>();
            System.Diagnostics.Debug.WriteLine(entity.nombre);

            try
            {
                using (var context = new UsuarioBEContext())
                {
                    list = context.entity.Where(
                    x => (x.codigo == entity.codigo || entity.codigo == "") 
                        && (x.apellido == entity.apellido || entity.apellido == "")
                        && (x.idGenero == entity.idGenero || entity.idGenero == 0)
                        && (x.idNacionalidad == entity.idNacionalidad || entity.idNacionalidad == 0)
                        && (x.idPerfil == entity.idPerfil || entity.idPerfil == 0)
                        ).ToList();

                }
                System.Diagnostics.Debug.WriteLine(entity.codigo);
                System.Diagnostics.Debug.WriteLine(list.Count);
                return list;


            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);

                return list;
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2);

                return list;
            }
            

        }

        public List<Genero> ListarGenero()
        {
            List<Genero> list = new List<Genero>();

            try
            {
                using (var context = new GeneroContext())
                {
                    list = context.entity.ToList();

                }

                return list;


            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);

                return list;
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2);

                return list;
            }
        }

        public List<Nacionalidad> ListarNacionalidades()
        {
            List<Nacionalidad> list = new List<Nacionalidad>();

            try
            {
                using (var context = new NacionesContext())
                {
                    list = context.entity.ToList();

                }

                return list;


            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);

                return list;
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2);

                return list;
            }
        }
        
        public List<Perfil> ListarPerfiles()
        {
            List<Perfil> list = new List<Perfil>();

            try
            {
                using (var context = new PerfilContext())
                {
                    list = context.entity.ToList();

                }

                return list;


            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);

                return list;
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2);

                return list;
            }
        }
    }
}
