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
using MyRentCar.Logica.Controladores;

namespace MyRentCar.UI.Formularios
{
    public partial class frmBusquedaCliente : Form
    {
        private ClienteController controller;
        public int Id;
        public frmBusquedaCliente()
        {
            InitializeComponent();
            this.controller = new ClienteController();
            List<ClienteDTO> clientesConsulta = new List<ClienteDTO>();
            foreach (Cliente cliente in controller.TraerClientes())
            {
                clientesConsulta.Add(new ClienteDTO(cliente));
            }
            clienteDTOBindingSource.DataSource = clientesConsulta;
        }

        private void FrmBusquedaCliente_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteDTO cliente = clienteDTOBindingSource.Current as ClienteDTO;
            this.Id = cliente.Cliente.Id;
            this.Close();
        }
    }
}
