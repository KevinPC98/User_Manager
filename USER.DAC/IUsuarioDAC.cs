using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USER.BE;

namespace USER.DAC
{
    public interface IUsuarioDAC
    {
        bool Insertar(UsuarioBE entity);
        List<UsuarioBE> Listar(UsuarioBE entity);
        List<Genero> ListarGenero();
        List<Nacionalidad> ListarNacionalidades();
        List<Perfil> ListarPerfiles();
    }
}
