using System.Windows.Forms;

namespace FarmaciaInventario
{
    partial class FormAlerta
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCriticos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCriticos = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticos)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvCriticos
            // 
            this.dgvCriticos.Location = new System.Drawing.Point(20, 20);
            this.dgvCriticos.Size = new System.Drawing.Size(500, 300);
            this.dgvCriticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // FormAlerta
            // 
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.dgvCriticos);
            this.Text = "Productos Críticos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
