﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.UI.Formularios.Reportes;

namespace MyRentCar.UI.Formularios
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MnuMarcas_Click(object sender, EventArgs e) { 
        
            frmMarcas f = new frmMarcas();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuTiposVehiculos_Click(object sender, EventArgs e)
        {
            frmTiposVehiculos f = new frmTiposVehiculos();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuCombustibles_Click(object sender, EventArgs e)
        {
            frmCombustibles f = new frmCombustibles();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuVehiculos_Click(object sender, EventArgs e)
        {
            frmVehiculos f = new frmVehiculos();
            f.MdiParent = this;
            f.Show();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados f = new frmEmpleados();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuTiposDocumentos_Click(object sender, EventArgs e)
        {
            frmTiposDocumentos f = new frmTiposDocumentos();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            frmClientes f = new frmClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuRenta_Click(object sender, EventArgs e)
        {
            frmRentas f = new frmRentas();
            f.MdiParent = this;
            f.Show();
        }

        private void TiposDeInspeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposInspecciones f = new frmTiposInspecciones();
            f.MdiParent = this;
            f.Show();
        }

        private void InspeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInspecciones f = new frmInspecciones();
            f.MdiParent = this;
            f.Show();
        }

        private void RentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteRentas f = new frmReporteRentas();
            f.MdiParent = this;
            f.Show();
        }
    }
}
