using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Notebook:Producto
    {
        private string microprocesador;
        private ETipoMemoria tipoMemoria;
        private int memoria;
        private int ram;
        private int stock;

        public Notebook(string marca, float precio, string origen, ECategoria categoria,string microprocesador,ETipoMemoria tipo, int memoria, int ram, int stock):base(marca,precio, origen, categoria)
        {
            this.microprocesador = microprocesador;
            this.tipoMemoria = tipo;
            this.memoria = memoria;
            this.ram = ram;
            this.stock = stock;
        }
        public int Stock
        {
            get { return this.stock; }
        }
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"INFORMACION DE LAS NOTEBOOKS");
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
