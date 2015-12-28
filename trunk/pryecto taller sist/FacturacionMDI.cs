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
    public partial class FacturacionMDI : Form
    {
        public FacturacionMDI()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm clientes = new ClientesForm();
            clientes.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosForm producto = new ProductosForm();
            producto.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaD fact = new FacturaD();
            fact.ShowDialog();
        }
    }
}
