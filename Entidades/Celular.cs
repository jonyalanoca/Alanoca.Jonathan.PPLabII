using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Celular:Producto
    {
        private string modelo;
        private string so;
        private float camara;
        private float pulgadas;
        private int memoria;
        public Celular(int id, string marca, float precio, string origen, ECategoria categoria, int stock,string modelo, string so, float camara, float pulgadas,int memoria) : base(id, marca, precio, origen, categoria, stock)
        {
            this.modelo = modelo;
            this.so = so;
            this.camara = camara;
            this.pulgadas = pulgadas;
            this.memoria = memoria;
        }
        /// <summary>
        /// crea un informe con los detalles del celular 
        /// </summary>
        /// <returns> retorna un string con los datos ordenados</returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"INFORMACION CELULAR");
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Categoria: {this.categoria.ToString()}");
            sb.AppendLine($"Sistema operativo: {this.so}");
            sb.AppendLine($"Camara: {this.camara}px");
            sb.AppendLine($"Pantalla {this.pulgadas} pulgadas");
            sb.AppendLine($"Memoria interna: {this.memoria}GB");
            sb.AppendLine($"Stock disponible: {this.stock}");
            return sb.ToString();
        }

    }
}
