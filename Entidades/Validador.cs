namespace Entidades
{
    public static class Validador
    {
        public static EPuesto Validar(string email, string pass)
        {
            EPuesto aux = EPuesto.Ninguno;
            foreach( var i in Negocio.UsuariosList)
            {
                if(i==email && i.Password == pass)
                {
                    if (i.GetType() == typeof(Vendedor))
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
    }
}