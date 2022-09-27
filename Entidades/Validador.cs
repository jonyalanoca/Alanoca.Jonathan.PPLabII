namespace Entidades
{
    public static class Validador
    {
        public static EPuesto Validar(string email, string pass)
        {
            foreach( var i in Negocio.VendedoresList)
            {
                if(i==email && i.Password == pass)
                {
                    return EPuesto.Vendedor;
                }
            }
            foreach (var i in Negocio.DueñosList)
            {
                if (i == email && i.Password == pass)
                {
                    return EPuesto.Dueño;
                }
            }
            return EPuesto.Ninguno;

        }
    }
}