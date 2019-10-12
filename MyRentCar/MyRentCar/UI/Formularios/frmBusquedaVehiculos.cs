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

namespace MyRentCar.UI.Formularios
{
    public partial class frmBusquedaVehiculos : Form
    {
        private MyRentCarContext db;
        private List<Vehiculo> listaVehiculos;
        public int Id;
        public frmBusquedaVehiculos()
        {
            InitializeComponent();
            this.db = new MyRentCarContext();
            this.listaVehiculos = db.Vehiculos.ToList();
            this.CargarVehiculos(this.listaVehiculos);
        }

        private void DgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vehiculo _vehiculo = (vehiculoDTOBindingSource.Current as VehiculoDTO).Vehiculo;
            this.Id = _vehiculo.Id;
            this.Close();
        }

        private List<Vehiculo> Filtrar(string busqueda)
        {
            return this.listaVehiculos.Where(v => (v.NumeroPlaca + v.Modelo.Descripcion + v.Modelo.Marca.Descripcion).Contains(busqueda)).ToList();
        }

        private void CargarVehiculos(List<Vehiculo> vehiculos)
        {
            List<VehiculoDTO> vehiculosConsultas = new List<VehiculoDTO>();
            foreach (Vehiculo v in vehiculos)
            {
                vehiculosConsultas.Add(new VehiculoDTO(v));
            }
            vehiculoDTOBindingSource.DataSource = vehiculosConsultas;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.CargarVehiculos(this.Filtrar(txtBusqueda.Text));
        }
    }
}
