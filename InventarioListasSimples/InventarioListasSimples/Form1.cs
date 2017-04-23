using System;
using System.Windows.Forms;

namespace InventarioListasSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario almacen = new Inventario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Producto item = new Producto();
            item.codigo = Convert.ToInt32(txbCodigo.Text);
            item.setNombre(txbNombre.Text);
            item.catidad = Convert.ToInt32(txbCandidad.Text);
            item.costo = Convert.ToInt32(txbPrecio.Text);

            almacen.agregar(item);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto item = new Producto();
            item.codigo = Convert.ToInt32(txbCodigo.Text);
            item.setNombre(txbNombre.Text);
            item.catidad = Convert.ToInt32(txbCandidad.Text);
            item.costo = Convert.ToInt32(txbPrecio.Text);
          
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txbReporte.Text = "";
            txbReporte.Text = almacen.reporte();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto item = new Producto();
            item.codigo = Convert.ToInt32(txbCodigo.Text);
            item.setNombre(txbNombre.Text);
            item.catidad = Convert.ToInt32(txbCandidad.Text);
            item.costo = Convert.ToInt32(txbPrecio.Text);
            //almacen.insertarItem(item, Convert.ToInt32(txbPosicion.Text));
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*
           Producto item;

           //item.codigo = Convert.ToInt32(txbBuscar.Text);
           item = almacen.buscarProducto(Convert.ToInt32(txbBuscar.Text));
           if (item == null)
               txbReporte.Text = "No exite el producto";
           else
           {
               txbReporte.Text = item.ToString();
           }
           */
        }


    }
}
