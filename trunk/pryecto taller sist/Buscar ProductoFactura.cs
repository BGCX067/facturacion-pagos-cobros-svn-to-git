using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pryecto_taller_sist
{
    public partial class Buscar_ProductoFactura : BuscarProducto
    {
        Productos misProductos;
        
        private int cantidad;

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        private int idProducto;

        public int IdProducto
        {
            get { return this.idProducto; }
            set { this.idProducto = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        private int precio;

        public int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public Buscar_ProductoFactura()
        {
            InitializeComponent();
        }

       

    
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_ProductoFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text.Length != 0)
            {
                this.idProducto = Convert.ToInt32(this.txtIdProducto.Text);
                this.descripcion = this.txtDescripcion.Text;
                this.precio = Convert.ToInt32(this.txtPrecio.Text);
                this.cantidad = Convert.ToInt32(this.txtCantidadd.Text);

                this.Close();
            }
            else
            {
                MessageBox.Show("Error, debe seleccionar un Producto");
            }
        }

        public void enlazarCaja()
        {
            Binding enlace;
            enlace = new Binding("Text", this.misProductos.Datos.DataSet, "PRODUCTOS.Id_Producto");
            this.txtIdProducto.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("Text", this.misProductos.Datos.DataSet, "PRODUCTOS.Descripcion");
            this.txtDescripcion.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("Text", this.misProductos.Datos.DataSet, "PRODUCTOS.Precio");
            this.txtPrecio.DataBindings.Add(enlace);
            enlace = null;
        }

        public void desenlazarCajas()
        {
            this.txtIdProducto.DataBindings.Clear();
            this.txtDescripcion.DataBindings.Clear();
            this.txtPrecio.DataBindings.Clear();
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void bntBuscar_Click_1(object sender, EventArgs e)
        {
            desenlazarCajas();
            this.misProductos = new Productos();
            this.misProductos.extraerDatosBusqueda("Descripcion", txtBuscar.Text);
            this.enlaceFomulario = BindingContext[this.misProductos.Datos.DataSet, "PRODUCTOS"];
            this.dgvClientes.DataSource = this.misProductos.Datos.DataSet;
            this.dgvClientes.DataMember = "PRODUCTOS";
            enlazarCaja();
        }

       

       
    }

}
 //enlace = new Binding("text", this.miClientes.Datos.DataSet, "CLIENTE.Apellido_P");
 //           this.txtApPaterno.DataBindings.Add(enlace);
 //           enlace = null;