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
    public partial class FacturaD : Plantilla
    {
        private DateTime fecha=DateTime.Now;
        public FacturaD()
        {
            InitializeComponent();
        }

        private void FacturaD_Load(object sender, EventArgs e)
        {
            txtFecha.Text = Convert.ToString(fecha);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Buscar_ProductoFactura buscar = new Buscar_ProductoFactura();
            buscar.ShowDialog();
            this.dgvFactura.Rows.Add();
            this.dgvFactura["colCant",dgvFactura.Rows.Count-1].Value=buscar.Cantidad;
            this.dgvFactura["colDesc", dgvFactura.Rows.Count - 1].Value = buscar.Descripcion;
            this.dgvFactura["colPrecio", dgvFactura.Rows.Count - 1].Value = buscar.Precio;
            this.dgvFactura["colTotal", dgvFactura.Rows.Count - 1].Value = (buscar.Cantidad * buscar.Precio);
            this.calcularTotal();
        }

        private void calcularTotal()
        {
            double suma = 0;
            for (int i = 0; i < dgvFactura.Rows.Count; i++)
            {
                suma = suma + Convert.ToDouble(this.dgvFactura["colTotal", i].Value);
            }
            this.txtTotal.Text = Convert.ToString(suma);
            
        }

        private void dgvFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.calcularTotal();
        }

      
    }
}
