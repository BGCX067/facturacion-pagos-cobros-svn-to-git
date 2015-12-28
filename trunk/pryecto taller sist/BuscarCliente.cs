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
    public partial class BuscarCliente : Plantilla
    {
        private int idCliente;

        public int IDCliente
        {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }

        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            Clientes misClientes = new Clientes();
            misClientes.extraerDatosBusqueda("CI", txtBuscar.Text);
            dgvClientes.DataSource = misClientes.Datos.DataSet;
            dgvClientes.DataMember = "CLIENTE";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
