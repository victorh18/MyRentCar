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
        public int IdCliente;
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

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdCliente = (clienteDTOBindingSource.Current as ClienteDTO).Cliente.Id;
            this.Close();
        }

        private void DgvClientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
