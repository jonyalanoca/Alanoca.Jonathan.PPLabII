using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
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
        public Usuario(string nombre, string apellido, int din, string email, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.din = din;
            this.email = email;
            this.password = password;
        }
        #endregion
        /// <summary>
        /// sobrecarga de operadores compara dos emails
        /// </summary>
        /// <param name="v"></param>
        /// <param name="email"></param>
        /// <returns> true si coinciden, false si no</returns>
        public static bool operator ==(Usuario v, string email)
        {
            return v.Email == email;
        }
        public static bool operator !=(Usuario v, string email)
        {
            return !(v == email);
        }
        /// <summary>
        /// Crea una presentacion de el usuario con nombre y apellido
        /// </summary>
        /// <returns> devuelve un string con el nombre completo</returns>
        public string CrearNombreCompleto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} {this.apellido}");
            return sb.ToString();
        }


    }
}
