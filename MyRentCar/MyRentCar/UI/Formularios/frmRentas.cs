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
using MyRentCar.Logica.Controladores;
using MyRentCar.Utilitarios.DTOs;

namespace MyRentCar.UI.Formularios
{
    public partial class frmRentas : Form
    {
        private RentaController controller;
        private Renta renta;
        public frmRentas()
        {
            InitializeComponent();
            controller = new RentaController();
            CargarConsultaRentas();
        }

        private void CargarConsultaRentas()
        {
            List<RentaDTO> rentasConsulta = new List<RentaDTO>();
            foreach (Renta r in controller.TraerRentas())
            {
                rentasConsulta.Add(new RentaDTO(r));
            }
            rentaDTOBindingSource.DataSource = rentasConsulta;
        }

        private void MostrarRenta(Renta _renta)
        {
            dtpFechaRenta.Value = _renta.FechaRenta ?? DateTime.Now;
            dtpFechaDevolucion.Value =_renta.FechaDevolucion ?? DateTime.Now;
            nudCantidadDias.Value = _renta.DiasRenta ?? 0;
            nudMontoPorDia.Value = 0;
            txtComentario.Text =_renta.Comentario ?? "";
            txtCliente.Text =_renta.Cliente.Nombre;
            txtPlacaVehiculo.Text =_renta.Vehiculo.NumeroPlaca;
            txtNumeroRenta.Text =_renta.Id.ToString();
            txtEmpleado.Text =_renta.Empleado.Nombre;
            txtVehiculo.Text =_renta.Vehiculo.Modelo.Marca.Descripcion + " " + renta.Vehiculo.Modelo.Descripcion;
        }

        private void LlenarRenta(Renta _renta)
        {
            _renta.FechaRenta = dtpFechaRenta.Value;
            //_renta.FechaDevolucion = dtpFechaDevolucion.Value;
            _renta.DiasRenta = (int) nudCantidadDias.Value;
            _renta.MontoDia = nudMontoPorDia.Value;
            _renta.Comentario = txtComentario.Text;
           
        }

        private void LimpiarCampos()
        {
            dtpFechaRenta.Text = "";
            dtpFechaDevolucion.Text = "";
            nudCantidadDias.Value = 0;
            nudMontoPorDia.Value = 0;
            txtComentario.Text = "";
            txtCliente.Text = "";
            txtPlacaVehiculo.Text = "";
            txtNumeroRenta.Text = "";
            txtEmpleado.Text = "";
            txtVehiculo.Text = "";
        }

        private void HabilitarCampos(bool valor)
        {
            dtpFechaRenta.Enabled = valor;
            dtpFechaDevolucion.Enabled = valor;
            nudCantidadDias.Enabled = valor;
            nudMontoPorDia.Enabled = valor;
            txtComentario.Enabled = valor;
            txtCliente.Enabled = valor;
            txtPlacaVehiculo.Enabled = valor;
            txtNumeroRenta.Enabled = valor;
            txtEmpleado.Enabled = valor;
            txtVehiculo.Enabled = valor;
        }

        private void NuevaRenta()
        {
            this.renta = new Renta();
            HabilitarCampos(true);
            MostrarRenta(this.renta);
        }

        private void Guardar(Renta _renta)
        {
            if (MessageBox.Show("¿Está seguro de que desea guardar la renta actual?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.controller.Guardar(renta);
            }
            MessageBox.Show("La renta se ha guardado exitosamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Eliminar(Renta _renta)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar la renta actual?","ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.controller.Eliminar(renta);
                LimpiarCampos();
                HabilitarCampos(false);
            }
        }

        private void BuscarCliente()
        {
            
        }

        private void BuscarVehiculo()
        {

        }

        private void BuscarEmpleado()
        {

        }
    }
}
