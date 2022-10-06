using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor:Usuario
    {
        private int edad;
        private List<EDias> diasLaborales;
        private float sueldo;
        public Vendedor(string nombre, string apellido, int dni, string email, string password,int edad,List<EDias> dias):base(nombre, apellido, dni,email, password)
        {
            this.diasLaborales = dias;
            this.edad = edad;
            this.sueldo = this.diasLaborales.Count * 4 * Negocio.PrecioPorDia;
        }
        public float SueldoMensual
        {
            get {return this.sueldo; }
        }
    }
}
