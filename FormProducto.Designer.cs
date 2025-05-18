using System.Windows.Forms;

namespace FarmaciaInventario
{
    partial class FormProducto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProductos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();

            // 
            // lblNombre
            // 
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(20, 20);

            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 20);
            this.txtNombre.Width = 200;

            // 
            // lblFecha
            // 
            this.lblFecha.Text = "Fecha Caducidad:";
            this.lblFecha.Location = new System.Drawing.Point(20, 60);

            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(120, 60);
            this.dtpFechaCaducidad.Width = 200;

            // 
            // lblStock
            // 
            this.lblStock.Text = "Stock:";
            this.lblStock.Location = new System.Drawing.Point(20, 100);

            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(120, 100);
            this.txtStock.Width = 200;

            // 
            // btnAgregar
            // 
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.Location = new System.Drawing.Point(120, 140);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // 
            // dgvProductos
            // 
            this.dgvProductos.Location = new System.Drawing.Point(20, 190);
            this.dgvProductos.Size = new System.Drawing.Size(500, 200);
            this.dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // FormProducto
            // 
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaCaducidad);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
