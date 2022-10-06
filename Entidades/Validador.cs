using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Entidades
{
    public static class Validador
    {
        /// <summary>
        /// Valida que el usuario y y contraceña pertenescan a un usuario registrado en el negocio.
        /// </summary>
        /// <param name="email"></param> Email del usuario
        /// <param name="pass"></param> contraceña del usuario
        /// <returns> devuelve el puesto al que pertenece el usuario</returns>
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
                    else if (user.GetType() == typeof(Dueño))
                    {
                        aux= EPuesto.Dueño;
                    }
                    else
                    {
                        aux = EPuesto.Contador;
                    }
                    break;
                }
            }
            return aux;
        }
        /// <summary>
        /// Verifica que el email pertenesca a un usuario registrado en el negocio
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="email"></param>
        /// <returns>devulve el usuario conincidente cone le email</returns>
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