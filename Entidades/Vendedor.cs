using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor:Usuario
    {
        private int edad;
        private static float precioDia;
        private static List<EDias> diasLaborales;
        private float sueldoMensual;
        static Vendedor()
        {
            Vendedor.diasLaborales = new List<EDias>();
            Vendedor.precioDia = 0;
        }
        public float SueldoMensual
        {
            set { Vendedor.precioDia = value; }
        }
        public Vendedor(string nombre, string apellido, int dni, string email, string password,int edad, float precioDia,List<EDias> dias):base(nombre, apellido, dni,email, password)
        {
            this.edad = edad;
            this.sueldoMensual = (float)diasLaborales.Count * Vendedor.precioDia;
            diasLaborales = dias;
        }
        public float Mostrar()
        {
            return this.sueldoMensual;
        }
    }
}
