using System.Collections.Generic;
using USER.BE;
using USER.DAC;

namespace USER.BL
{
    public class UsuarioBL: IUsuarioBL
    {
        private readonly IUsuarioDAC _usuarioDAC;
        public UsuarioBL()
        {
            _usuarioDAC = new UsuarioDAC();
        }

        public bool Insertar(UsuarioBE entity)
        {
            return _usuarioDAC.Insertar(entity);
        }

        public List<UsuarioBE> Listar(UsuarioBE entity)
        {
            System.Diagnostics.Debug.WriteLine(entity.codigo);

            return _usuarioDAC.Listar(entity);
        }

        public List<Genero> ListarGenero()
        {
            return _usuarioDAC.ListarGenero();
        }

        public List<Nacionalidad> ListarNacionalidades()
        {
            return _usuarioDAC.ListarNacionalidades();
        }

        public List<Perfil> ListarPerfiles()
        {
            return _usuarioDAC.ListarPerfiles();
        }
    }
}
