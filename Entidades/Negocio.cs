using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Negocio
    {
        private static List<Vendedor> vendedoresList;
        private static List<Dueño> dueñosList;
        private static Dictionary<string, string> loginsList;

        static Negocio()
        {
            Negocio.vendedoresList = new List<Vendedor>();
            Negocio.dueñosList = new List<Dueño>();
            Negocio.loginsList = new Dictionary<string, string>();

            List<EDias> dias = new List<EDias>() { EDias.Lunes, EDias.Martes,EDias.Miercoles,EDias.Miercoles,EDias.Jueves,EDias.Viernes};
            Negocio.vendedoresList.Add(new Vendedor("Jonathan", "Alanoca", 373777700, "jonyalanoca2@gmail.com", "contra123,", 20, 40000, dias));
            Negocio.vendedoresList.Add(new Vendedor("Gerardo", "Aduviri", 363734300, "geraraduviri@gmail.com", "123contra,", 29, 40000, dias));
            Negocio.vendedoresList.Add(new Vendedor("Carolina", "Osorio", 403944933, "caroosrio@gmail.com", "pass123,", 25, 40000, dias));

            Negocio.dueñosList.Add(new Dueño("Camila", "Simpson", 401231232, "camisimpson@gmail.com", "123pass"));

            foreach(var i in vendedoresList)
            {
                Negocio.loginsList.Add(i.Email, i.Password);
            }
            foreach (var i in dueñosList)
            {
                Negocio.loginsList.Add(i.Email, i.Password);
            }


        }
        public static  Dictionary<string, string> LoginsList
        {
            get { return Negocio.loginsList;}
        }



    }
}
