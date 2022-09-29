using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private string marca;
        protected float precio;
        protected string origen;
        protected ECategoria categoria;
        public Producto(string marca, float precio,string origen, ECategoria categoria){
            this.marca= marca;
            this.precio = precio;
            this.origen = origen;
            this.categoria = categoria;
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
    }
}
