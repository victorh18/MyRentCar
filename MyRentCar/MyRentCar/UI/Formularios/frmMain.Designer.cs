namespace MyRentCar.UI.Formularios
{
    partial class frmMain
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTiposVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCombustibles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTiposDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeInspeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimientos,
            this.reportesToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // mnuMantenimientos
            // 
            this.mnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTiposVehiculos,
            this.mnuCombustibles,
            this.mnuTiposDocumentos,
            this.tiposDeInspeccionesToolStripMenuItem,
            this.mnuMarcas,
            this.mnuVehiculos,
            this.empleadosToolStripMenuItem,
            this.mnuClientes,
            this.mnuRenta,
            this.inspeccionesToolStripMenuItem});
            this.mnuMantenimientos.Name = "mnuMantenimientos";
            this.mnuMantenimientos.Size = new System.Drawing.Size(106, 20);
            this.mnuMantenimientos.Text = "Mantenimientos";
            // 
            // mnuMarcas
            // 
            this.mnuMarcas.Name = "mnuMarcas";
            this.mnuMarcas.Size = new System.Drawing.Size(195, 22);
            this.mnuMarcas.Text = "Marcas";
            this.mnuMarcas.Click += new System.EventHandler(this.MnuMarcas_Click);
            // 
            // mnuTiposVehiculos
            // 
            this.mnuTiposVehiculos.Name = "mnuTiposVehiculos";
            this.mnuTiposVehiculos.Size = new System.Drawing.Size(195, 22);
            this.mnuTiposVehiculos.Text = "Tipos de Vehículos";
            this.mnuTiposVehiculos.Click += new System.EventHandler(this.MnuTiposVehiculos_Click);
            // 
            // mnuCombustibles
            // 
            this.mnuCombustibles.Name = "mnuCombustibles";
            this.mnuCombustibles.Size = new System.Drawing.Size(195, 22);
            this.mnuCombustibles.Text = "Tipos de Combustibles";
            this.mnuCombustibles.Click += new System.EventHandler(this.MnuCombustibles_Click);
            // 
            // mnuVehiculos
            // 
            this.mnuVehiculos.Name = "mnuVehiculos";
            this.mnuVehiculos.Size = new System.Drawing.Size(195, 22);
            this.mnuVehiculos.Text = "Vehículos";
            this.mnuVehiculos.Click += new System.EventHandler(this.MnuVehiculos_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // mnuTiposDocumentos
            // 
            this.mnuTiposDocumentos.Name = "mnuTiposDocumentos";
            this.mnuTiposDocumentos.Size = new System.Drawing.Size(195, 22);
            this.mnuTiposDocumentos.Text = "Tipos de Documentos";
            this.mnuTiposDocumentos.Click += new System.EventHandler(this.mnuTiposDocumentos_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(195, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuRenta
            // 
            this.mnuRenta.Name = "mnuRenta";
            this.mnuRenta.Size = new System.Drawing.Size(195, 22);
            this.mnuRenta.Text = "Renta";
            this.mnuRenta.Click += new System.EventHandler(this.MnuRenta_Click);
            // 
            // tiposDeInspeccionesToolStripMenuItem
            // 
            this.tiposDeInspeccionesToolStripMenuItem.Name = "tiposDeInspeccionesToolStripMenuItem";
            this.tiposDeInspeccionesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tiposDeInspeccionesToolStripMenuItem.Text = "Tipos de Inspecciones";
            this.tiposDeInspeccionesToolStripMenuItem.Click += new System.EventHandler(this.TiposDeInspeccionesToolStripMenuItem_Click);
            // 
            // inspeccionesToolStripMenuItem
            // 
            this.inspeccionesToolStripMenuItem.Name = "inspeccionesToolStripMenuItem";
            this.inspeccionesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inspeccionesToolStripMenuItem.Text = "Inspecciones";
            this.inspeccionesToolStripMenuItem.Click += new System.EventHandler(this.InspeccionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.rentasToolStripMenuItem.Text = "Rentas";
            this.rentasToolStripMenuItem.Click += new System.EventHandler(this.RentasToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuMarcas;
        private System.Windows.Forms.ToolStripMenuItem mnuTiposVehiculos;
        private System.Windows.Forms.ToolStripMenuItem mnuCombustibles;
        private System.Windows.Forms.ToolStripMenuItem mnuVehiculos;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTiposDocumentos;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuRenta;
        private System.Windows.Forms.ToolStripMenuItem tiposDeInspeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
    }
}