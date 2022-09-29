using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre;
        protected string marca;
        protected float precio;
        protected string origen;
        protected ECategoria categoria;
        
        public Producto(string marca, float precio,string origen, ECategoria categoria)
        {
            this.marca= marca;
            this.precio = precio;
            this.origen = origen;
            this.categoria = categoria;
        }
        public Producto(string nombre, string marca, float precio, string origen, ECategoria categoria):this(marca, precio, origen, categoria)
        {
            this.nombre = nombre;
        }
        #region setters y getters
        public string Marca
        {
            get { return this.marca; }
        }
        public string Origen
        {
            get { return this.origen; }
        }

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public ECategoria Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }
#endregion
        public virtual string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"iNFORMACION PRODUCTO GENERAL");
            sb.AppendLine($"Producto: {this.nombre}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Categoria: {this.categoria.ToString()}");
            return sb.ToString();
        }
    }
}
