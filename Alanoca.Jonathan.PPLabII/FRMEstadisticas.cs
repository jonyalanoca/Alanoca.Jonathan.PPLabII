using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_tp1
{
    public partial class FRMEstadisticas : Form
    {
        private Usuario usuarioLogeado;

        
        public FRMEstadisticas(Usuario usser)
        {
            InitializeComponent();
            this.usuarioLogeado = usser;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag=false;
            int cantMasVendida = 0;
            double promedio;
            int cantidad=0;
              double catTotalVendido=0;
            Producto masVendido=null;
        ECategoria cat=ECategoria.Otros;
            switch (cmbCategoria.Text)
            {
                case  "Computación":
                    cat=ECategoria.Computación;
                    break;
                case "Celulares":
                    cat = ECategoria.Celulares;
                    break;
                case "Herramientas":
                    cat = ECategoria.Herramientas;
                    break;
                case "Otros":
                    cat = ECategoria.Otros;
                    break;
                case "Electrodomesticos":
                    cat = ECategoria.Electrodomesticos;
                    break;
            }
            foreach(var i in Negocio.HistorialVentas)
            {
                if (i.ProductoC.Categoria == cat)
                {
                    catTotalVendido += i.Total;
                    cantidad++;
                    if (flag == false)
                    {
                        flag = true;
                        masVendido = i.ProductoC;
                        cantMasVendida = i.Cantidad;
                    }else if(flag==true && i.Cantidad > cantMasVendida)
                    {
                        masVendido = i.ProductoC;
                        cantMasVendida = i.Cantidad;
                    }
                }
            }
            promedio = catTotalVendido / cantidad;
            lblPromedio_data.Text=promedio.ToString();
            lblTotalTag.Text = catTotalVendido.ToString();
            lblProdMasVendidoTag.Text = masVendido.Id.ToString();

        }

        private void FRMEstadisticas_Load(object sender, EventArgs e)
        {
            int ventaTotal = 0;
            double totalVendido=0;

            foreach (var i in Enum.GetValues(typeof(ECategoria)))
            {
                cmbCategoria.Items.Add(i.ToString());
            }
            foreach (var i in Negocio.HistorialVentas)
            {
                totalVendido += i.Total;
            }
            lblTotVentas_data.Text = Negocio.HistorialVentas.Count.ToString();
            lblTotGan_data.Text = totalVendido.ToString();
        }
    }
}
