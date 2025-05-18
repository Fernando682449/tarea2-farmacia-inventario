using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmaciaInventario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto formProducto = new FormProducto();
            formProducto.ShowDialog();
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            FormAlerta formAlerta = new FormAlerta();
            formAlerta.ShowDialog();
        }
    }
}
