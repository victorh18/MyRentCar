﻿namespace MyRentCar.UI.Formularios
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
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimientos});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msMenu.Size = new System.Drawing.Size(1200, 35);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // mnuMantenimientos
            // 
            this.mnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMarcas,
            this.mnuTiposVehiculos,
            this.mnuCombustibles,
            this.mnuVehiculos,
            this.empleadosToolStripMenuItem,
            this.mnuTiposDocumentos});
            this.mnuMantenimientos.Name = "mnuMantenimientos";
            this.mnuMantenimientos.Size = new System.Drawing.Size(152, 29);
            this.mnuMantenimientos.Text = "Mantenimientos";
            // 
            // mnuMarcas
            // 
            this.mnuMarcas.Name = "mnuMarcas";
            this.mnuMarcas.Size = new System.Drawing.Size(278, 30);
            this.mnuMarcas.Text = "Marcas";
            this.mnuMarcas.Click += new System.EventHandler(this.MnuMarcas_Click);
            // 
            // mnuTiposVehiculos
            // 
            this.mnuTiposVehiculos.Name = "mnuTiposVehiculos";
            this.mnuTiposVehiculos.Size = new System.Drawing.Size(278, 30);
            this.mnuTiposVehiculos.Text = "Tipos de Vehículos";
            this.mnuTiposVehiculos.Click += new System.EventHandler(this.MnuTiposVehiculos_Click);
            // 
            // mnuCombustibles
            // 
            this.mnuCombustibles.Name = "mnuCombustibles";
            this.mnuCombustibles.Size = new System.Drawing.Size(278, 30);
            this.mnuCombustibles.Text = "Tipos de Combustibles";
            this.mnuCombustibles.Click += new System.EventHandler(this.MnuCombustibles_Click);
            // 
            // mnuVehiculos
            // 
            this.mnuVehiculos.Name = "mnuVehiculos";
            this.mnuVehiculos.Size = new System.Drawing.Size(278, 30);
            this.mnuVehiculos.Text = "Vehículos";
            this.mnuVehiculos.Click += new System.EventHandler(this.MnuVehiculos_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // mnuTiposDocumentos
            // 
            this.mnuTiposDocumentos.Name = "mnuTiposDocumentos";
            this.mnuTiposDocumentos.Size = new System.Drawing.Size(278, 30);
            this.mnuTiposDocumentos.Text = "Tipos de Documentos";
            this.mnuTiposDocumentos.Click += new System.EventHandler(this.mnuTiposDocumentos_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}