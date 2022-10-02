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
        private static int idProducto;
        private static int horasPorDia;
        private static double dineroCaja;
        private static int numeroClientes;
        static Negocio()
        {
            Negocio.idProducto = 100;
            Negocio.precioPorDia = 3000;
            Negocio.horasPorDia = 5;
            Negocio.dineroCaja = 20000.20;
            Negocio.numeroClientes = 900312;
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
            Negocio.productosList.Add(new Producto(Negocio.idProducto++,"Cafetera", "TopHouse", 50000, "Argentina", ECategoria.Electrodomesticos,50));
            Negocio.productosList.Add(new Producto(Negocio.idProducto++, "Tijera", "Pizzini", 5000, "Alemania",ECategoria.Herramientas,200));
            Negocio.productosList.Add(new Producto(Negocio.idProducto++, "Crimping", "Nisuta", 5000, "Japon", ECategoria.Herramientas, 20));
            Negocio.productosList.Add(new Producto(Negocio.idProducto++, "Cortapelo", "Pizzini", 5000, "Alemania", ECategoria.Otros,20));
            Negocio.productosList.Add(new Producto(Negocio.idProducto++, "Mouse", "Logitech", 5000, "Brasil", ECategoria.Computación, 150));
            Negocio.productosList.Add(new Notebook(Negocio.idProducto++, "Lenovo", 200000, "China", ECategoria.Computación,20, "corei5", ETipoMemoria.SSD, 240, 4));
            Negocio.productosList.Add(new Notebook(Negocio.idProducto++, "HP", 500000, "EEUU", ECategoria.Computación, 10, "corei9", ETipoMemoria.M2, 480, 8));
            Negocio.productosList.Add(new Celular(Negocio.idProducto++, "Huawei",30000,"China",ECategoria.Celulares,10,"Y9","Andriod11",12,(float)6.59,128));
            Negocio.productosList.Add(new Celular(Negocio.idProducto++, "Samsung", 47000, "China", ECategoria.Celulares, 3, "GalaxyA3", "Andriod12", 48, (float)6.5, 128));
            Negocio.productosList.Add(new Celular(Negocio.idProducto++, "Motorola", 60000, "China", ECategoria.Celulares, 9, "MotoG5", "Andriod12", 50, (float)6.6, 128));
            Negocio.productosList.Add(new Celular(Negocio.idProducto++, "Morotola", 150000, "China", ECategoria.Celulares, 2, "Edge20Pro", "Andriod13", 108, (float)6.7, 256));
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
        public static int HorasPorDia
        {
            get { return Negocio.horasPorDia; }
        }
        public static double DineroCaja
        {
            get { return Negocio.dineroCaja; }
        }
        public static int NumeroClientes
        {
            get { return Negocio.numeroClientes; }
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
