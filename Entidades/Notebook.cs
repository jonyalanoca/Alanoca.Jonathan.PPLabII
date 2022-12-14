using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Notebook:Producto
    {
        private string microprocesador;
        private ETipoMemoria tipoMemoria;
        private int memoria;
        private int ram;

        public Notebook(int id, string marca, float precio, string origen, ECategoria categoria, int stock,string microprocesador,ETipoMemoria tipo, int memoria, int ram):base(id,marca,precio, origen, categoria, stock)
        {
            this.microprocesador = microprocesador;
            this.tipoMemoria = tipo;
            this.memoria = memoria;
            this.ram = ram;
        }
        /// <summary>
        /// Crea un detalle con todos los datos importante de una notebook.
        /// </summary>
        /// <returns> devuelve un string </returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"INFORMACION NOTEBOOKS");
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Categoria: {this.categoria.ToString()}");
            sb.AppendLine($"Microprocesador: {this.microprocesador}");
            sb.AppendLine($"Memoria: {this.tipoMemoria} de {this.memoria}GB");
            sb.AppendLine($"Memoria RAM: {this.ram}GB");
            sb.AppendLine($"Stock disponible: {this.stock}");
            return sb.ToString();
        }

    }
}
