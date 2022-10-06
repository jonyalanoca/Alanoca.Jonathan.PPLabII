using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contador : Usuario
    {
        public Contador(string nombre, string apellido, int dni, string email, string password) : base(nombre, apellido, dni, email, password)
        {

        }
    }
}
