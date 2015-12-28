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
    public partial class ProductosForm : Plantilla
    {
        Productos miProducto;
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            this.miProducto = new Productos();
            this.miProducto.extraerTodosProductos();
            this.enlaceFomulario = BindingContext[miProducto.Datos.DataSet, "PRODUCTOS"];

            this.dgvClientes.DataSource = miProducto.Datos.DataSet;
            this.dgvClientes.DataMember = "PRODUCTOS";
            this.enlazarCajas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
        
            this.desenlazarCajas();
            this.borrarCajas();
            this.estadoCajasNuevo(false);
            this.estadoBotones(false);

        }
        public void desenlazarCajas()
        {
            this.txtId.DataBindings.Clear();
            this.txtDescripcion.DataBindings.Clear();
            this.txtPrecio.DataBindings.Clear();
            this.txtStock.DataBindings.Clear();
           
        }
        public void borrarCajas()
        {
            this.txtId.Clear();
            this.txtDescripcion.Clear();
            this.txtPrecio.Clear();
            this.txtStock.Clear();
            this.txtId.Focus();
        }
        public void estadoCajasNuevo(bool soloLectura)
        {
            this.txtId.ReadOnly = soloLectura;
            this.estadoCajasActualizar(soloLectura);
        }
        public void estadoCajasActualizar(bool soloLectura)
        {
            this.txtDescripcion.ReadOnly = soloLectura;
            this.txtPrecio.ReadOnly = soloLectura;
            this.txtStock.ReadOnly = soloLectura;
           
        }

        public void estadoBotones(bool estado)
        {
            btnNuevo.Enabled = estado;
            btnActualizar.Enabled = estado;
            btnEliminar.Enabled = estado;
            btnGuardar.Enabled = !estado;
            btnCancelar.Enabled = !estado;
            btnBuscar.Enabled = estado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
          
            this.desenlazarCajas();
            this.estadoCajasActualizar(false);
            this.estadoBotones(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
            
        }
        public void eliminar()
        {
            this.enlaceFomulario.RemoveAt(enlaceFomulario.Position);
            this.miProducto.guardarProducto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtId.ReadOnly)
            {
                this.miProducto.nuevoProducto  (Convert.ToInt32(txtId.Text),txtDescripcion.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtStock.Text));
            }
            else
            {
                this.eliminar();
                this.miProducto.nuevoProducto(Convert.ToInt32(txtId.Text), txtDescripcion.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtStock.Text));

            }
            this.miProducto.guardarProducto();
            this.borrarCajas();
            this.enlazarCajas();
            this.estadoBotones(true);
            this.estadoCajasNuevo(true);

        }

        public void enlazarCajas()
        {
            Binding enlace;
            enlace = new Binding("text", this.miProducto.Datos.DataSet, "PRODUCTOS.Id_Producto");
            this.txtId.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miProducto.Datos.DataSet, "PRODUCTOS.Descripcion");
            this.txtDescripcion.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miProducto.Datos.DataSet, "PRODUCTOS.Precio");
            this.txtPrecio.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miProducto.Datos.DataSet, "PRODUCTOS.Stock");
            this.txtStock.DataBindings.Add(enlace);
            enlace = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            this.borrarCajas();
            this.enlazarCajas();
            this.estadoCajasNuevo(true);
            this.estadoBotones(true);
         }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
                BuscarProducto buscar = new BuscarProducto();
                buscar.ShowDialog();
            
        }
        

    }
}
