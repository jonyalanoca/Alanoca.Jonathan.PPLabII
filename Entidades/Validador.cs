using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Entidades
{
    public static class Validador
    {
        public static EPuesto Validar(string email, string pass)
        {
            EPuesto aux = EPuesto.Ninguno;
            foreach( Usuario user in Negocio.UsuariosList)
            {
                if(user == email && user.Password == pass)
                {
                    if (user.GetType() == typeof(Vendedor))
                    {
                        aux = EPuesto.Vendedor;
                    }
                    else
                    {
                        aux= EPuesto.Dueño;
                    }
                    break;
                }
            }
            return aux;
        }
        public static Usuario Validar ( List<Usuario> lista, string email)
        {
            Usuario auxUsuario=null;
            foreach (Usuario user in Negocio.UsuariosList)
            {
                if (user == email)
                {
                    auxUsuario = user;
                    break;
                }
            }
            return auxUsuario;
        }
    }
}