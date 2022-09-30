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
        private static List<Usuario> usuariosList;
        private static List<Producto> productosList;
        private static float precioPorDia;

        static Negocio()
        {
            Negocio.precioPorDia = 3000;
            Negocio.usuariosList = new List<Usuario>();
            Negocio.productosList = new List<Producto>();

            List<EDias> dias = new List<EDias>() { EDias.Lunes, EDias.Martes,EDias.Miercoles,EDias.Jueves,EDias.Viernes};
            //Agregando Vendedores
            Negocio.usuariosList.Add(new Vendedor("Jonathan", "Alanoca", 37377700, "jonyalanoca2@gmail.com", "contra123", 29, dias));
            Negocio.usuariosList.Add(new Vendedor("Gerardo", "Aduviri", 363734300, "geraduviri@gmail.com", "123contra", 29, dias));
            Negocio.usuariosList.Add(new Vendedor("Carolina", "Osorio", 403944933, "caroosorio@gmail.com", "pass123", 25, dias));
            //Agregando Dueños
            Negocio.usuariosList.Add(new Dueño("Camila", "Simpson", 401231232, "camisimpson@gmail.com", "123pass"));
            //Agregando productos a la tienda
            Negocio.productosList.Add(new Producto("Cafetera", "TopHouse", 50000, "Argentina", ECategoria.Electrodomesticos,50));
            Negocio.productosList.Add(new Producto("Tijera", "Pizzini", 5000, "Alemania",ECategoria.Herramientas,200));
            Negocio.productosList.Add(new Producto("Crimping", "Nisuta", 5000, "Japon", ECategoria.Herramientas, 20));
            Negocio.productosList.Add(new Producto("Cortapelo", "Pizzini", 5000, "Alemania", ECategoria.Otros,20));
            Negocio.productosList.Add(new Producto("Mouse", "Logitech", 5000, "Brasil", ECategoria.Computación, 150));
            Negocio.productosList.Add(new Notebook("Lenovo", 200000, "China", ECategoria.Computación,20, "corei5", ETipoMemoria.SSD, 240, 4));
            Negocio.productosList.Add(new Notebook("HP", 500000, "EEUU", ECategoria.Computación, 10, "corei9", ETipoMemoria.M2, 480, 8));
            Negocio.productosList.Add(new Celular("Huawei",30000,"China",ECategoria.Celulares,10,"Y9","Andriod11",12,(float)6.59,128));
            Negocio.productosList.Add(new Celular("Samsung", 47000, "China", ECategoria.Celulares, 3, "GalaxyA3", "Andriod12", 48, (float)6.5, 128));
            Negocio.productosList.Add(new Celular("Motorola", 60000, "China", ECategoria.Celulares, 9, "MotoG5", "Andriod12", 50, (float)6.6, 128));
            Negocio.productosList.Add(new Celular("Morotola", 150000, "China", ECategoria.Celulares, 2, "Edge20Pro", "Andriod13", 108, (float)6.7, 256));
        }
        public static List<Usuario> UsuariosList
        {
            get { return Negocio.usuariosList; }
        }
        public static float PrecioPorDia
        {
            get { return Negocio.precioPorDia; }
            set { Negocio.precioPorDia = value; }
        }
        public static List<Producto> ProductosList
        {
            get { return Negocio.productosList; }
        }
        public static string ObtenerNombreCompleto(string email)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var i in Negocio.usuariosList)
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
