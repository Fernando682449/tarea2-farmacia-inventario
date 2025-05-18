namespace FarmaciaInventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbIDusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.MenuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.Panel1.Controls.Add(this.lbNombreUsuario);
            this.Panel1.Controls.Add(this.picUsuario);
            this.Panel1.Controls.Add(this.btnVentas);
            this.Panel1.Controls.Add(this.btnPOS);
            this.Panel1.Controls.Add(this.btnLogin);
            this.Panel1.Controls.Add(this.btnSalir);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 72);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(315, 723);
            this.Panel1.TabIndex = 9;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombreUsuario.BackColor = System.Drawing.Color.DimGray;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbNombreUsuario.Location = new System.Drawing.Point(3, 122);
            this.lbNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(311, 37);
            this.lbNombreUsuario.TabIndex = 9;
            this.lbNombreUsuario.Text = "Menu";
            this.lbNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistro,
            this.MenuReporte,
            this.MenuAdministracion,
            this.menuAyuda});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1241, 72);
            this.MenuStrip1.TabIndex = 10;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Controls.Add(this.StatusStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(315, 72);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(926, 723);
            this.mainPanel.TabIndex = 11;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.StUsuario,
            this.ToolStripStatusLabel2,
            this.LbIDusuario});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 697);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(926, 26);
            this.StatusStrip1.TabIndex = 0;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(59, 20);
            this.ToolStripStatusLabel1.Text = "Usuario";
            // 
            // StUsuario
            // 
            this.StUsuario.Name = "StUsuario";
            this.StUsuario.Size = new System.Drawing.Size(15, 20);
            this.StUsuario.Text = "-";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(24, 20);
            this.ToolStripStatusLabel2.Text = "ID";
            // 
            // LbIDusuario
            // 
            this.LbIDusuario.Name = "LbIDusuario";
            this.LbIDusuario.Size = new System.Drawing.Size(17, 20);
            this.LbIDusuario.Text = "0";
            // 
            // picUsuario
            // 
            this.picUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(0, 0);
            this.picUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(315, 122);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 8;
            this.picUsuario.TabStop = false;
            this.picUsuario.Click += new System.EventHandler(this.picUsuario_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.SlateGray;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(16, 303);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(279, 98);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.SlateGray;
            this.btnPOS.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Black;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Location = new System.Drawing.Point(16, 197);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(279, 98);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(16, 409);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(279, 98);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(16, 597);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(279, 98);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // MenuRegistro
            // 
            this.MenuRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem1,
            this.RegistroDeClientesToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.MenuRegistro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRegistro.ForeColor = System.Drawing.Color.Black;
            this.MenuRegistro.Image = ((System.Drawing.Image)(resources.GetObject("MenuRegistro.Image")));
            this.MenuRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuRegistro.Name = "MenuRegistro";
            this.MenuRegistro.Size = new System.Drawing.Size(187, 68);
            this.MenuRegistro.Text = "Registro";
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(179, 28);
            this.ToolStripMenuItem3.Text = "Clientes";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(179, 28);
            this.ToolStripMenuItem2.Text = "Productos";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(179, 28);
            this.ToolStripMenuItem1.Text = "Categorias";
            // 
            // RegistroDeClientesToolStripMenuItem
            // 
            this.RegistroDeClientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroDeClientesToolStripMenuItem.Name = "RegistroDeClientesToolStripMenuItem";
            this.RegistroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.RegistroDeClientesToolStripMenuItem.Text = "Inventario";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.SalirToolStripMenuItem.Text = "Salir";
            // 
            // MenuReporte
            // 
            this.MenuReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem5});
            this.MenuReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuReporte.ForeColor = System.Drawing.Color.Black;
            this.MenuReporte.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporte.Image")));
            this.MenuReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReporte.Name = "MenuReporte";
            this.MenuReporte.Size = new System.Drawing.Size(194, 68);
            this.MenuReporte.Text = "Reportes";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(236, 28);
            this.ToolStripMenuItem5.Text = "Reporte de ventas";
            // 
            // MenuAdministracion
            // 
            this.MenuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem10});
            this.MenuAdministracion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAdministracion.ForeColor = System.Drawing.Color.Black;
            this.MenuAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("MenuAdministracion.Image")));
            this.MenuAdministracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAdministracion.Name = "MenuAdministracion";
            this.MenuAdministracion.Size = new System.Drawing.Size(267, 68);
            this.MenuAdministracion.Text = "Administración";
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(252, 28);
            this.ToolStripMenuItem10.Text = "Registro de usuarios";
            // 
            // menuAyuda
            // 
            this.menuAyuda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAyuda.ForeColor = System.Drawing.Color.Black;
            this.menuAyuda.Image = ((System.Drawing.Image)(resources.GetObject("menuAyuda.Image")));
            this.menuAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(165, 68);
            this.menuAyuda.Text = "Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 795);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel mainPanel;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel StUsuario;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel LbIDusuario;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lbNombreUsuario;
        internal System.Windows.Forms.PictureBox picUsuario;
        internal System.Windows.Forms.Button btnVentas;
        internal System.Windows.Forms.Button btnPOS;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem MenuRegistro;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem RegistroDeClientesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MenuReporte;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem MenuAdministracion;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem10;
        internal System.Windows.Forms.ToolStripMenuItem menuAyuda;
    }
}

