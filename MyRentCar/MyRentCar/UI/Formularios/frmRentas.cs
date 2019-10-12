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
            HabilitarCampos(false);
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
            txtCliente.Text =_renta?.Cliente?.Nombre ?? "";
            txtPlacaVehiculo.Text =_renta?.Vehiculo?.NumeroPlaca ?? "";
            txtNumeroRenta.Text = _renta?.Id.ToString();
            txtEmpleado.Text =_renta?.Empleado?.Nombre ?? "";
            txtVehiculo.Text =_renta?.Vehiculo?.Modelo?.Marca?.Descripcion ?? "" + " " + renta?.Vehiculo?.Modelo?.Descripcion ?? "";
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
            this.controller.Guardar(renta);
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
            frmBusquedaCliente f = new frmBusquedaCliente();
            f.ShowDialog();
            this.renta.Cliente = controller.Buscar<Cliente>(f.IdCliente);
            txtCliente.Text = this.renta.Cliente.Nombre;
        }

        private void BuscarVehiculo()
        {
            frmBusquedaVehiculos f = new frmBusquedaVehiculos();
            f.ShowDialog();
            this.renta.Vehiculo = controller.Buscar<Vehiculo>(f.Id);
            txtVehiculo.Text = this?.renta?.Vehiculo?.NombreVehiculo;
            txtPlacaVehiculo.Text = this?.renta?.Vehiculo?.NumeroPlaca;
        }

        private void BuscarEmpleado()
        {
            frmBusquedaEmpleado f = new frmBusquedaEmpleado();
            f.ShowDialog();
            this.renta.Empleado = controller.Buscar<Empleado>(f.IdEmpleado);
            txtEmpleado.Text = this.renta.Empleado.Nombre;
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaRenta();

        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea guardar la renta actual?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (this.Validar())
                {
                    LlenarRenta(this.renta);
                    Guardar(this.renta);
                    MessageBox.Show("Los datos de la renta se han guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }

        private void TxtCliente_DoubleClick(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void TxtEmpleado_DoubleClick(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void TxtPlacaVehiculo_DoubleClick(object sender, EventArgs e)
        {
            BuscarVehiculo();

        }

        private void TxtVehiculo_DoubleClick(object sender, EventArgs e)
        {
            BuscarVehiculo();
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPlacaVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRentas_Load(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            if (txtEmpleado.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un empleado válido.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtPlacaVehiculo.Text.Trim() == "" || txtVehiculo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un vehículo válido.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un cliente válido.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (nudMontoPorDia.Value <= 0)
            {
                MessageBox.Show("Debe asignar un monto por día válido.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;

        }

        
    }
}
