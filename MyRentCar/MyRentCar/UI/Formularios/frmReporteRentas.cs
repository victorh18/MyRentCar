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
        private Cliente cliente;
        private Empleado empleado;
        private Vehiculo vehiculo;
        private Modelo modelo;
        public frmReporteRentas()
        {
            InitializeComponent();
            this.controller = new RentaController();
            cbxCombustible.DataSource = controller.Traer<TipoCombustible>();
            cbxCombustible.DisplayMember = "Descripcion";
            cbxCombustible.ValueMember = "Id";

            cbxTipoVehiculo.DataSource = controller.Traer<TipoVehiculo>();
            cbxTipoVehiculo.DisplayMember = "Descripcion";
            cbxTipoVehiculo.ValueMember = "Id";
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

        private void AsignarCliente()
        {
            frmBusquedaCliente f = new frmBusquedaCliente();
            f.ShowDialog();
            this.cliente = controller.Buscar<Cliente>(f.IdCliente);
            if (this.cliente != null)
            {
                txtCliente.Text = this.cliente.Nombre;
            }
        }

        private void AsignarEmpleado()
        {
            frmBusquedaEmpleado f = new frmBusquedaEmpleado();
            f.ShowDialog();
            this.empleado = controller.Buscar<Empleado>(f.IdEmpleado);
            if (this.empleado != null)
            {
                txtEmpleado.Text = this.empleado.Nombre;
            }
        }

        private void AsignarModelo()
        {
            frmBusquedaModelo f = new frmBusquedaModelo();
            f.ShowDialog();
            this.modelo = controller.Buscar<Modelo>(f.IdModelo);
            if (this.modelo != null)
            {
                this.vehiculo = null;
                txtNumeroPlaca.Text = "";
                txtVehiculo.Text = this.modelo.Descripcion;
                cbxTipoVehiculo.SelectedItem = this.modelo.TipoVehiculo;
                
            }
        }

        private void AsignarVehiculo()
        {
            frmBusquedaVehiculos f = new frmBusquedaVehiculos();
            f.ShowDialog();
            this.vehiculo = controller.Buscar<Vehiculo>(f.Id);
            if (this.vehiculo != null)
            {
                cbxTipoVehiculo.SelectedItem = this.vehiculo.Modelo.TipoVehiculo;
                cbxCombustible.SelectedItem = this.vehiculo.TipoCombustible;
                txtVehiculo.Text = this.vehiculo.NombreVehiculo;
                txtNumeroPlaca.Text = this.vehiculo.NumeroPlaca;
            }
        }

        private void TxtCliente_DoubleClick(object sender, EventArgs e)
        {
            AsignarCliente();
        }

        private void TxtEmpleado_DoubleClick(object sender, EventArgs e)
        {
            AsignarEmpleado();
        }

        private void TxtVehiculo_DoubleClick(object sender, EventArgs e)
        {
            AsignarModelo();
        }

        private void TxtNumeroPlaca_DoubleClick(object sender, EventArgs e)
        {
            AsignarVehiculo();
        }

        private void LimpiarVehiculos()
        {
            this.modelo = null;
            this.vehiculo = null;
            txtVehiculo.Text = "";
            txtNumeroPlaca.Text = "";
        }

        private void CbxTipoVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LimpiarVehiculos();
        }

        private void CbxCombustible_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LimpiarVehiculos();
        }

        private void LblFechaDesde_Click(object sender, EventArgs e)
        {

        }

        private void LblHasta_Click(object sender, EventArgs e)
        {

        }
    }
}
