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
    public partial class Plantilla : Form
    {
        protected BindingManagerBase enlaceFomulario;

        public BindingManagerBase EnlaceFormulario
        {
            get { return this.enlaceFomulario; }
            set { this.enlaceFomulario = value; }
        }

        public Plantilla()
        {
            InitializeComponent();
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {

        }

        
    }
}
