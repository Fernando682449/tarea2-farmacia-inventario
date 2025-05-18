namespace FarmaciaInventario
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnAlertas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(50, 40);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 40);
            this.btnProductos.Text = "Gestión de Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            // 
            // btnAlertas
            // 
            this.btnAlertas.Location = new System.Drawing.Point(50, 100);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(200, 40);
            this.btnAlertas.Text = "Ver Alertas de Stock";
            this.btnAlertas.UseVisualStyleBackColor = true;
            this.btnAlertas.Click += new System.EventHandler(this.btnAlertas_Click);

            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnAlertas);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Farmacia";
            this.ResumeLayout(false);
        }
    }
}
