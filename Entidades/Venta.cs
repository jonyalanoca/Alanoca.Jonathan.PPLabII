using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private DateTime fecha;
        private Usuario vendedor;
        private Producto producto;
        private double precio;
        private int cantidad;
        private bool targeta;
        private double recargo;
        private double total;
        private Venta()
        {
            this.fecha =  DateTime.Now;
            this.targeta=false;
            this.recargo = 0;
        }
        public Venta(Usuario vendedor, Producto prod, int cantidad):this()
        {
            this.vendedor = vendedor;
            this.producto = prod;
            this.cantidad = cantidad;
            this.precio = prod.Precio;
            this.total = prod.Precio * cantidad;
        }
        public Venta(Usuario vendedor, Producto prod, int cantidad,bool targeta,double recargo):this(vendedor, prod, cantidad)
        {
            this.targeta=targeta;
            this.recargo = recargo;
            this.total += recargo;
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
        }
        public string Vendedor
        {
            get { return vendedor.Nombre + " " + vendedor.Apellido; }
        }
        public int Producto
        {
            get { return this.producto.Id; }
        }
        public double Precio
        {
            get { return this.precio; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
        }
        public string Targeta
        {
            get
            {
                if (this.targeta == true)
                {
                    return "Con tarjeta";
                }
                return "Efectivo";
            }
        }
        public double Recargo
        {
            get { return this.recargo; }
        }
        public double Total
        {
            get { return this.total; }
        }
    }
}
