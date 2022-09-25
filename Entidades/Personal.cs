using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int din;
        protected string email;
        protected string password;
        #endregion
        #region Setters y getters
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        #endregion
        #region Constructores
        public Personal(string nombre, string apellido, int din, string email, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.din = din;
            this.email = email;
            this.password = password;
        }
        #endregion

    }
}
