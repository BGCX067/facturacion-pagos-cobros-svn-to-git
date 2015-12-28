namespace pryecto_taller_sist
{
    partial class Buscar_ProductoFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadd = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(395, 67);
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(395, 259);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(314, 259);
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(615, 34);
            this.lblTitulo.Text = "Buscar Producto Factura";
            // 
            // gbTitulo
            // 
            this.gbTitulo.Controls.Add(this.txtPrecio);
            this.gbTitulo.Controls.Add(this.txtDescripcion);
            this.gbTitulo.Controls.Add(this.txtIdProducto);
            this.gbTitulo.Location = new System.Drawing.Point(88, 58);
            this.gbTitulo.Size = new System.Drawing.Size(518, 370);
            this.gbTitulo.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.gbTitulo.Controls.SetChildIndex(this.btnCancelar, 0);
            this.gbTitulo.Controls.SetChildIndex(this.txtBuscar, 0);
            this.gbTitulo.Controls.SetChildIndex(this.bntBuscar, 0);
            this.gbTitulo.Controls.SetChildIndex(this.txtIdProducto, 0);
            this.gbTitulo.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.gbTitulo.Controls.SetChildIndex(this.txtPrecio, 0);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(16, 74);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(20, 294);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(66, 20);
            this.txtIdProducto.TabIndex = 12;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // txtCantidadd
            // 
            this.txtCantidadd.Location = new System.Drawing.Point(16, 100);
            this.txtCantidadd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadd.Name = "txtCantidadd";
            this.txtCantidadd.Size = new System.Drawing.Size(66, 20);
            this.txtCantidadd.TabIndex = 4;
            this.txtCantidadd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(20, 332);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(66, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(142, 332);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(66, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // Buscar_ProductoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadd);
            this.Controls.Add(this.txtCantidad);
            this.Name = "Buscar_ProductoFactura";
            this.Text = "Buscar_ProductoFactura";
            this.Load += new System.EventHandler(this.Buscar_ProductoFactura_Load);
            this.Controls.SetChildIndex(this.gbTitulo, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtCantidadd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.gbTitulo.ResumeLayout(false);
            this.gbTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.NumericUpDown txtCantidadd;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}