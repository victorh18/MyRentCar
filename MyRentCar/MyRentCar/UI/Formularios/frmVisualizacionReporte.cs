using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.Data.Modelos;
using MyRentCar.Utilitarios.DTOs;
using Microsoft.Reporting.WinForms;

namespace MyRentCar.UI.Formularios.Reportes
{
    public partial class frmVisualizacionReporte : Form
    {
        public frmVisualizacionReporte(string reporte, ReportDataSource dataSource)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reporte;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);
        }

        private void FrmVisualizacionReporte_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
