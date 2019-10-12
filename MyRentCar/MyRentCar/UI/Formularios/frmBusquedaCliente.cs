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
        private MyRentCarContext db;
        private List<Cliente> clientes;
        public int IdCliente;
        public frmBusquedaCliente()
        {
            InitializeComponent();
            this.db = new MyRentCarContext();
            this.clientes = db.Clientes.ToList();
            
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdCliente = (clienteDTOBindingSource.Current as ClienteDTO).Cliente.Id;
            this.Close();
        }

        private List<Cliente> Filtrar(string busqueda)
        {
            return this.clientes.Where(c => (c.Nombre + c.NumeroDocumento).Contains(busqueda)).ToList();
        }

        private void CargarClientes(IEnumerable<Cliente> _clientes)
        {
            List<ClienteDTO> clientesConsulta = new List<ClienteDTO>();
            foreach (Cliente cliente in _clientes)
            {
                clientesConsulta.Add(new ClienteDTO(cliente));
            }
            clienteDTOBindingSource.DataSource = clientesConsulta;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.CargarClientes(this.Filtrar(txtBusqueda.Text));
        }
    }
}
