using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.UI.Formularios.Reportes;
using MyRentCar.Logica.Controladores;
using MyRentCar.Data.Modelos;
using MyRentCar.Utilitarios.DTOs;
using Microsoft.Reporting.WinForms;

namespace MyRentCar.UI.Formularios.Reportes
{
    public partial class frmReporteRentas : Form
    {
        private RentaController controller;
        public frmReporteRentas()
        {
            InitializeComponent();
            this.controller = new RentaController();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<RentaDTO> rentas = new List<RentaDTO>();
            foreach (Renta r in controller.TraerRentas())
            {
                rentas.Add(new RentaDTO(r));
            }
            ReportDataSource ds = new ReportDataSource("DataSet1", rentas);

            frmVisualizacionReporte f = new frmVisualizacionReporte("MyRentCar.UI.Formularios.Reportes.rptRentas.rdlc", ds);
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
