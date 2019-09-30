﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.Logica.Controladores;
using MyRentCar.Data.Modelos;
using MyRentCar.Utilitarios.DTOs;
using MyRentCar.Utilitarios.Validaciones;

namespace MyRentCar.UI.Formularios
{
    public partial class frmVehiculos : Form
    { 
        private VehiculosController controller;
        private Vehiculo vehiculo;
        public frmVehiculos()
        {
            InitializeComponent();
            controller = new VehiculosController();
            cbxCombustible.DataSource = controller.TraerCombustibles();
            cbxCombustible.DisplayMember = "Descripcion";
            cbxCombustible.ValueMember = "Id";
            LimpiarCampos();
            HabilitarControles(false);

            CargarVehiculosConsultas();
        }
        
        private void LlenarVehiculo(Vehiculo _vehiculo)
        {
            _vehiculo.Descripcion = txtDescripcion.Text;
            _vehiculo.Estado = chkEstado.Checked;
            _vehiculo.NumeroPlaca = txtNumeroPlaca.Text;
            _vehiculo.NumeroChasis = txtNumeroChasis.Text;
            _vehiculo.NumeroMotor = txtNumeroMotor.Text;
            _vehiculo.TipoCombustible = cbxCombustible.SelectedItem as TipoCombustible;
        }

        private void MostrarVehiculo(Vehiculo _vehiculo)
        {
            HabilitarControles(true);
            cbxCombustible.SelectedItem = _vehiculo.TipoCombustible;
            txtMarca.Text = _vehiculo?.Modelo?.Marca?.Descripcion ?? "";
            txtModelo.Text = _vehiculo?.Modelo?.Descripcion ?? "";
            txtNumeroChasis.Text = _vehiculo?.NumeroChasis ?? "";
            txtNumeroMotor.Text = _vehiculo?.NumeroMotor ?? "";
            txtNumeroPlaca.Text = _vehiculo?.NumeroPlaca ?? "";
            txtDescripcion.Text = _vehiculo?.Descripcion ?? "";
            chkEstado.Checked = _vehiculo?.Estado ?? false;

        }

        private void NuevoVehiculo()
        {
            vehiculo = new Vehiculo();
            MostrarVehiculo(vehiculo);
            HabilitarControles(true);
        }

        private void LimpiarCampos()
        {
            cbxCombustible.SelectedItem = null;
            txtMarca.Text = "";
            txtNumeroChasis.Text = "";
            txtNumeroMotor.Text = "";
            txtNumeroPlaca.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = true;
        }

        private void HabilitarControles(bool valor)
        {
            cbxCombustible.Enabled = valor;
            txtNumeroChasis.Enabled = valor;
            txtNumeroPlaca.Enabled = valor;
            txtNumeroMotor.Enabled = valor;
            txtDescripcion.Enabled = valor;
            //dgvVehiculos.Enabled = valor;
            
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {

        }
        
        private void Guardar(Vehiculo _vehiculo)
        {
            controller.Guardar(_vehiculo);
            MessageBox.Show("El vehículo ha sido guardado correctamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarVehiculosConsultas();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoVehiculo();
        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea guardar el vehículo actual?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                LlenarVehiculo(vehiculo);
                if (ValidacionesVehiculos.ValidarVehiculo(vehiculo))
                {
                    Guardar(vehiculo);
                }        
            }
            return;
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar el vehículo actual?", "VERIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controller.ExisteVehiculo(vehiculo))
                {
                    controller.Eliminar(vehiculo);
                }
                LimpiarCampos();
                return;
            }
        }

        private void BuscarModelo()
        {
            frmBusquedaModelo f = new frmBusquedaModelo();
            f.ShowDialog();
            Modelo modelo = controller.BuscarModelo(f.modelo);
            if (modelo != null)
            {
                this.vehiculo.Modelo = modelo;
                txtMarca.Text = this.vehiculo.Modelo.Marca.Descripcion;
                txtModelo.Text = this.vehiculo.Modelo.Descripcion;
            }

        }

        private void TxtModelo_DoubleClick(object sender, EventArgs e)
        {
            BuscarModelo();
        }

        private void CargarVehiculosConsultas()
        {
            List<VehiculoDTO> vehiculosConsulta = new List<VehiculoDTO>();
            foreach (Vehiculo v in controller.TraerVehiculos())
            {
                vehiculosConsulta.Add(new VehiculoDTO(v));
            }
            vehiculoDTOBindingSource.DataSource = vehiculosConsulta;
        }

        private void dgvVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VehiculoDTO vehiculoDTO = vehiculoDTOBindingSource.Current as VehiculoDTO;
            vehiculo = vehiculoDTO.Vehiculo;
            MostrarVehiculo(vehiculo);
        }
    }
}
