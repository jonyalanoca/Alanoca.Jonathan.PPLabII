using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_tp1
{
    public partial class FRMAdministracion : Form
    {
        private List<Producto> listaFiltrada;


        public FRMAdministracion()
        {
            InitializeComponent();
            listaFiltrada = new List<Producto>();
        }

        private void FRMAdministracion_Load(object sender, EventArgs e)
        {
            Filtrar();
            CargarDatagrid();
        }
        /// <summary>
        /// hace una copia de la lista de productos del negocio en un lista especial para esta seccion
        /// </summary>
        private void Filtrar()
        {
            this.listaFiltrada.Clear();
            foreach (var i in Negocio.ProductosList)
            {
                this.listaFiltrada.Add(i);
            }
        }
        /// <summary>
        /// filtra  segun la categoria inidicada por parametro de la lista de productos del negocio y los carga en la lista especial para esta sección
        /// </summary>
        /// <param name="categoria"></param>
        private void Filtrar(ECategoria categoria)
        {
            this.listaFiltrada.Clear();
            foreach (var i in Negocio.ProductosList)
            {

                if (i.Categoria == categoria)
                {
                    this.listaFiltrada.Add(i);
                }
            }
        }
        /// <summary>
        /// cargalos datos del data gridview con los registros de la lista especial para esta seccion
        /// </summary>
        private void CargarDatagrid()
        {
            foreach (var i in this.listaFiltrada)
            {
                dgvListaProductos.Rows.Add(i.Id, i.Marca, i.Origen, i.Categoria.ToString(), i.Precio, i.Stock);

            }
        }
        /// <summary>
        /// Realiza varias acciones Repetitivas en el codigo(DRY)
        /// Borrar:borrar o resetea los datos 
        /// filtrar: filtra segun la categoria pasado por parametro.
        /// Cargar: carga el datagridview con los nuevo datos
        /// </summary>
        /// <param name="categoria"></param>
        private void BorrarFiltrarYCargar(ECategoria categoria)
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            rdbMayorPrecio.Checked = false;
            rdbMenorPrecio.Checked = false;
            dgvListaProductos.Rows.Clear();
            Filtrar(categoria);
            CargarDatagrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void rdbComputacion_CheckedChanged(object sender, EventArgs e)
        {
            BorrarFiltrarYCargar(ECategoria.Computación);
        }

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {
            BorrarFiltrarYCargar(ECategoria.Celulares);
        }

        private void rdbElectro_CheckedChanged(object sender, EventArgs e)
        {
            BorrarFiltrarYCargar(ECategoria.Electrodomesticos);
        }

        private void rdbHerramientas_CheckedChanged(object sender, EventArgs e)
        {
            BorrarFiltrarYCargar(ECategoria.Herramientas);
        }

        private void rdbTodo_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            dgvListaProductos.Rows.Clear();
            Filtrar();
            CargarDatagrid();
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int i = dgvListaProductos.CurrentRow.Index;
            foreach (var prod in Negocio.ProductosList)
            {
                if (prod == (int)dgvListaProductos.Rows[i].Cells[0].Value)
                {
                    lblDetalle_data.Text = prod.MostrarInfo().ToString();
                    break;
                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            dgvListaProductos.Rows.Clear();
            listaFiltrada.Sort(FMayorPrecio);
            CargarDatagrid();
        }
        private void rdbMenorPrecio_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            dgvListaProductos.Rows.Clear();
            listaFiltrada.Sort(FMenorPrecio);
            CargarDatagrid();
        }
        /// <summary>
        /// funcion especial para usarlo en el sort.sorter una lista
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>
        /// -1 si el precio1 es mayor al precio2
        /// 1: si el precio1 es menor o igual al precio2
        /// </returns>
        private int FMayorPrecio(Producto x, Producto y)
        {
            if (x.Precio > y.Precio)
            {
                return -1;
            }
            return 1;
        }
        /// <summary>
        /// funcion especial para usarlo en el sort.sorter una lista
        /// Compara dos precio
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>
        /// 1:si el precio 1 es mayor que el precio2
        /// -1:si el precio1 es menor o igual al precio2
        /// /// </returns>
        private  static int FMenorPrecio(Producto x, Producto y)
        {
            if (x.Precio > y.Precio)
            {
                return 1;
            }
            return -1;
        }

        private void btnFiltrarPrecio_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtDesde.Text) < int.Parse(txtHasta.Text))
            {

                dgvListaProductos.Rows.Clear();
                foreach (var i in this.listaFiltrada)
                {
                    if(i.Precio>=int.Parse(txtDesde.Text) && i.Precio <= int.Parse(txtHasta.Text))
                    dgvListaProductos.Rows.Add(i.Id, i.Marca, i.Origen, i.Categoria.ToString(), i.Precio, i.Stock);

                }

            }
            else
            {
                MessageBox.Show("El rango no es valido.\nVerifique los datos ingresados", "Fallo la validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rdbTodo.Checked = true;
            rdbMayorPrecio.Checked = false;
            rdbMayorPrecio.Checked = false;
            txtDesde.Text = "";
            txtHasta.Text = "";
            dgvListaProductos.Rows.Clear();
            Filtrar();
            foreach (var i in this.listaFiltrada)
            {
                if (rdbMarca.Checked == true)
                {
                    if (i.Marca.Contains(txtPalabraBuscar.Text))
                    {
                        dgvListaProductos.Rows.Add(i.Id, i.Marca, i.Origen, i.Categoria.ToString(), i.Precio, i.Stock);
                    }
                }
                else
                {
                    if (i.Origen.Contains(txtPalabraBuscar.Text))
                    {
                        dgvListaProductos.Rows.Add(i.Id, i.Marca, i.Origen, i.Categoria.ToString(), i.Precio, i.Stock);
                    }
                }
                    

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = dgvListaProductos.CurrentRow.Index;
            foreach(var prod in Negocio.ProductosList)
            {
                if (prod.Id == (int)dgvListaProductos.Rows[i].Cells[0].Value)
                {
                    if(MessageBox.Show("¿Seguro que desea eliminar el producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Negocio.ProductosList.Remove(prod);
                        dgvListaProductos.Rows.Clear();
                        Filtrar();
                        CargarDatagrid();
                        break;
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int i = dgvListaProductos.CurrentRow.Index;
            foreach (var prod in Negocio.ProductosList)
            {
                if (prod.Id == (int)dgvListaProductos.Rows[i].Cells[0].Value)
                {
                    FRMEditar frmEditar = new FRMEditar(prod);
                    frmEditar.ShowDialog();
                    break;
                }
            }
            dgvListaProductos.Rows.Clear();
            Filtrar();
            CargarDatagrid();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMAgregar frmAgregar = new FRMAgregar();
            frmAgregar.ShowDialog();
            this.Show();
            dgvListaProductos.Rows.Clear();
            Filtrar();
            CargarDatagrid();
        }
    }
}
