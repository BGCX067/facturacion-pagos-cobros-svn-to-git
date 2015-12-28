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
    public partial class BuscarProducto : Plantilla
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            Productos misClientes = new Productos();
            misClientes.extraerDatosBusqueda("Descripcion", txtBuscar.Text);
            dgvClientes.DataSource = misClientes.Datos.DataSet;
            dgvClientes.DataMember = "PRODUCTOS";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
