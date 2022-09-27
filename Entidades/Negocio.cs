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
        private static float precioPorDia;

        static Negocio()
        {
            Negocio.precioPorDia = 3000;
            Negocio.vendedoresList = new List<Vendedor>();
            Negocio.dueñosList = new List<Dueño>();
            Negocio.loginsList = new Dictionary<string, string>();

            List<EDias> dias = new List<EDias>() { EDias.Lunes, EDias.Martes,EDias.Miercoles,EDias.Jueves,EDias.Viernes};
            Negocio.vendedoresList.Add(new Vendedor("Jonathan", "Alanoca", 37377700, "jonyalanoca2@gmail.com", "contra123", 29, dias));
            Negocio.vendedoresList.Add(new Vendedor("Gerardo", "Aduviri", 363734300, "geraduviri@gmail.com", "123contra", 29, dias));
            Negocio.vendedoresList.Add(new Vendedor("Carolina", "Osorio", 403944933, "caroosorio@gmail.com", "pass123", 25, dias));

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
        public static List<Vendedor> VendedoresList
        {
            get { return Negocio.vendedoresList; }
        }
        public static List<Dueño> DueñosList
        {
            get { return Negocio.dueñosList; }
        }
        public static float PrecioPorDia
        {
            get { return Negocio.precioPorDia; }
            set { Negocio.precioPorDia = value; }
        }
        public static string Presentacion(string email)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var i in Negocio.vendedoresList)
            {
                if (i == email)
                {
                    sb.Append($"{i.Nombre} {i.Apellido}");
                    break;
                }
            }
            foreach (var i in Negocio.dueñosList)
            {
                if (i == email)
                {
                    sb.Append($"{i.Nombre} {i.Apellido}");
                    break;
                }
            }
            return sb.ToString();
        }
    }
}
