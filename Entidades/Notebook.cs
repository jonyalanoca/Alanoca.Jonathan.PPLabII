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
        private int ssd;
        private int ram;
        private static int stock;
        static Notebook()
        {
            Notebook.stock = 0;
        }
        public Notebook(string marca, float precio, string origen, ECategoria categoria,string microprocesador, int ssd, int ram):base(marca,precio, origen, categoria)
        {
            this.microprocesador = microprocesador;
            this.ssd = ssd;
            this.ram = ram;
        }
        
    }
}
