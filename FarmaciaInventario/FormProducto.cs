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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = RepositorioProducto.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    FechaCaducidad = dtpFechaCaducidad.Value,
                    Stock = int.Parse(txtStock.Text)
                };

                RepositorioProducto.Agregar(p);
                MessageBox.Show("Producto registrado correctamente.");
                CargarProductos();

                // Limpia campos
                txtNombre.Text = "";
                txtStock.Text = "";
                dtpFechaCaducidad.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
    }
}
