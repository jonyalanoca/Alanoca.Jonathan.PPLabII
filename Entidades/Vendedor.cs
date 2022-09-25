using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor:Personal
    {
        private int edad;
        private float sueldo;
        private static List<EDias> diasLaborales;
        static Vendedor()
        {
            Vendedor.diasLaborales = new List<EDias>();
        }
        public Vendedor(string nombre, string apellido, int dni, string email, string password,int edad, float sueldo,List<EDias> dias):base(nombre, apellido, dni,email, password)
        {
            this.edad = edad;
            this.sueldo = sueldo;
            diasLaborales = dias;
        }
    }
}
