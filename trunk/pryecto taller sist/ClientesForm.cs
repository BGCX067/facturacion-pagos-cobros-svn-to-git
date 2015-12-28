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
    public partial class ClientesForm : Plantilla
    {
        Clientes miClientes;
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            this.miClientes = new Clientes();
            this.miClientes.extraerClienteTodosClientes();
            this.enlaceFomulario=BindingContext[miClientes.Datos.DataSet,"CLIENTE"];
            
            this.dgvClientes.DataSource = miClientes.Datos.DataSet;
            this.dgvClientes.DataMember = "CLIENTE";
            this.enlazarCajas();
        }

        public void enlazarCajas()
        {
            Binding enlace;
            enlace = new Binding("text",this.miClientes.Datos.DataSet, "CLIENTE.Id_Cliente");
            this.txtId.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miClientes.Datos.DataSet, "CLIENTE.Nombre");
            this.txtNombre.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miClientes.Datos.DataSet, "CLIENTE.Apellido_P");
            this.txtApPaterno.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miClientes.Datos.DataSet, "CLIENTE.Apellido_M");
            this.txtApMaterno.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miClientes.Datos.DataSet, "CLIENTE.CI");
            this.txtCI.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miClientes.Datos.DataSet, "CLIENTE.Dirección");
            this.txtDireccion.DataBindings.Add(enlace);
            enlace = null;
            enlace = new Binding("text", this.miClientes.Datos.DataSet, "CLIENTE.Teléfono");
            this.txtTelefono.DataBindings.Add(enlace);
            enlace = null;
        }

        public void desenlazarCajas()
        {
            this.txtId.DataBindings.Clear();
            this.txtNombre.DataBindings.Clear();
            this.txtApPaterno.DataBindings.Clear();
            this.txtApMaterno.DataBindings.Clear();
            this.txtCI.DataBindings.Clear();
            this.txtDireccion.DataBindings.Clear();
            this.txtTelefono.DataBindings.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.desenlazarCajas();
            this.borrarCajas();
            this.estadoCajasNuevo(false);
            this.estadoBotones(false);

        }

        public void borrarCajas()
        {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtApPaterno.Clear();
            this.txtApMaterno.Clear();
            this.txtCI.Clear();
            this.txtDireccion.Clear();
            this.txtTelefono.Clear();
            this.txtId.Focus();
        }

        public void estadoCajasNuevo(bool soloLectura)
        {
            this.txtId.ReadOnly = soloLectura;
            this.estadoCajasActualizar(soloLectura);
        }

        public void estadoCajasActualizar(bool soloLectura)
        {
            this.txtNombre.ReadOnly = soloLectura;
            this.txtApPaterno.ReadOnly = soloLectura;
            this.txtApMaterno.ReadOnly = soloLectura;
            this.txtCI.ReadOnly = soloLectura;
            this.txtDireccion.ReadOnly = soloLectura;
            this.txtTelefono.ReadOnly = soloLectura;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.borrarCajas();
            this.enlazarCajas();
            this.estadoCajasNuevo(true);
            this.estadoBotones(true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.desenlazarCajas();
            this.estadoCajasActualizar(false);
            this.estadoBotones(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtId.ReadOnly)
            {
                this.miClientes.nuevoCliente(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, Convert.ToInt32(txtCI.Text), txtDireccion.Text, Convert.ToInt32(txtTelefono.Text));
            }
            else
            {
                this.eliminar();
                this.miClientes.nuevoCliente(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, Convert.ToInt32(txtCI.Text), txtDireccion.Text, Convert.ToInt32(txtTelefono.Text));

            }
            this.miClientes.guardarClientes();
            this.borrarCajas();
            this.enlazarCajas();
            this.estadoBotones(true);
            this.estadoCajasNuevo(true);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
            
        }

        public void eliminar()
        {
            this.enlaceFomulario.RemoveAt(enlaceFomulario.Position);
            this.miClientes.guardarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente buscar = new BuscarCliente();
            buscar.ShowDialog();
        }
    }
}
