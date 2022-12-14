using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected int id;
        private string nombre;
        protected string marca;
        protected float precio;
        protected string origen;
        protected ECategoria categoria;
        protected int stock;
        public Producto(int id, string marca, float precio,string origen, ECategoria categoria, int stock)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.origen = origen;
            this.categoria = categoria;
            this.stock = stock;
        }
        public Producto(int id, string nombre, string marca, float precio, string origen, ECategoria categoria, int stock):this(id,marca, precio, origen, categoria, stock)
        {
            this.nombre = nombre;
        }
        #region setters y getters
        public int Id
        {
            get { return this.id; }
        }
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
        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
        #endregion
        /// <summary>
        /// Crea un string detallando los valores de la clase, ordenado.
        /// </summary>
        /// <returns> devuelve un string con el detalle</returns>
        public virtual string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"PRODUCTO GENERAL");
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Producto: {this.nombre}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Categoria: {this.categoria.ToString()}");
            sb.AppendLine($"Stock disponible: {this.stock}");
            return sb.ToString();
        }
        public  static bool operator ==(Producto p, int id)
        {
            return p.Id == id;
        }
        public static bool operator !=(Producto p, int id)
        {
            return !(p == id);
        }
        /// <summary>
        /// disminuye el stock
        /// </summary>
        /// <param name="p"></param>
        /// <param name="num"></param>
        /// <returns>retorna el restultado de la resta</returns>
        public static int operator -(Producto p, int num)
        {
            return p.stock - num;
        }
    }
}
