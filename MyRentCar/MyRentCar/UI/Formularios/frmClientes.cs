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
    public partial class frmClientes : Form
    {
        private ClienteController controller;
        private Cliente cliente;
        public frmClientes()
        {
            InitializeComponent();
            controller = new ClienteController();
            CargarClientesConsulta();
            HabilitarControles(false);
            cbxTipoDocumento.DataSource = controller.TraerTiposDocumentos();
            cbxTipoDocumento.DisplayMember = "Descripcion";
            cbxTipoDocumento.ValueMember = "Id";
        }

        private void LblTipoDocumento_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void MostrarCliente(Cliente _cliente)
        {
            txtNombre.Text = _cliente?.Nombre ?? "";
            txtNumeroDocumento.Text = _cliente.NumeroDocumento ?? "";
            cbxTipoDocumento.SelectedItem = _cliente.TipoDocumento;
            txtTarjetaCredito.Text = _cliente?.NumeroTarjetaCredito ?? "";
            nudLimiteCredito.Value = _cliente?.LimiteCredito ?? 0;
            chkEstado.Checked = _cliente?.Estado ?? false;
        }

        private void LlenarCliente(Cliente _cliente)
        {
            _cliente.Nombre = txtNombre.Text;
            _cliente.NumeroDocumento = txtNumeroDocumento.Text;
            _cliente.TipoDocumento = cbxTipoDocumento.SelectedItem as TipoDocumento;
            _cliente.NumeroTarjetaCredito = txtTarjetaCredito.Text;
            _cliente.LimiteCredito = nudLimiteCredito.Value;
            _cliente.Estado = chkEstado.Checked;
        }

        private void NuevoCliente()
        {
            this.cliente = new Cliente();
            MostrarCliente(cliente);
        }

        private void Guardar(Cliente _cliente)
        {
            controller.Guardar(_cliente);
        }

        private void LimpiarControles()
        {
            txtNombre.Text = "";
            txtNumeroDocumento.Text = "";
            cbxTipoDocumento.SelectedItem = null;
            txtTarjetaCredito.Text = "";
            nudLimiteCredito.Value = 0;
            chkEstado.Checked = true;
        }

        private void HabilitarControles(bool valor)
        {
            txtNombre.Enabled = valor;
            txtNumeroDocumento.Enabled = valor;
            cbxTipoDocumento.Enabled = valor;
            txtTarjetaCredito.Enabled = valor;
            nudLimiteCredito.Enabled = valor;
            chkEstado.Enabled = valor;
            
        }

        private void CargarClientesConsulta()
        {
            List<ClienteDTO> clientesConsulta = new List<ClienteDTO>();
            foreach (Cliente c in controller.TraerClientes())
            {
                clientesConsulta.Add(new ClienteDTO(c));
            }
            dgvClientesConsulta.DataSource = clientesConsulta;
            
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente();
            LimpiarControles();
            HabilitarControles(true);

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas guardar el cliente actual?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LlenarCliente(this.cliente);
                if (ValidarCliente(this.cliente))
                {
                    controller.Guardar(this.cliente);
                }
                MessageBox.Show("Los datos del cliente han sido guardados correctamente.");
            }
        }

        private bool ValidarCliente(Cliente cliente)
        {
            if (cliente.TipoDocumento.Descripcion == "CEDULA" && cliente.NumeroDocumento.Length != 11)
            {
                MessageBox.Show("La cédula del cliente debe contener 11 números.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cliente.TipoDocumento.Descripcion == "RNC" && cliente.NumeroDocumento.Length != 9)
            {
                MessageBox.Show("El RNC del cliente debe contener 9 números.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
}
