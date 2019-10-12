using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.Logica.Controladores;
using MyRentCar.Utilitarios.DTOs;
using MyRentCar.Data.Modelos;

namespace MyRentCar.UI.Formularios
{
    public partial class frmBusquedaModelo : Form
    {
        private MyRentCarContext db;
        private List<Modelo> modelos;
        public int IdModelo;
        public frmBusquedaModelo()
        {
            InitializeComponent();
            db = new MyRentCarContext();
            this.modelos = db.Modelos.ToList();
            this.CargarModelos(this.modelos);
        }

        private void FrmBusquedaModelo_Load(object sender, EventArgs e)
        {

        }

        private void DgvModelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModeloDTO m = modeloDTOBindingSource.Current as ModeloDTO;
            this.IdModelo = m.Modelo.Id;
            this.Close();
        }

        private List<Modelo> Filtrar(string busqueda)
        {
            return this.modelos.Where(m => (m.Marca.Descripcion + m.Descripcion).Contains(busqueda)).ToList();
        }

        private void CargarModelos(List<Modelo> _modelos)
        {
            List<ModeloDTO> modelos = new List<ModeloDTO>();
            foreach (var m in _modelos)
            {
                modelos.Add(new ModeloDTO(m));
            }

            modeloDTOBindingSource.DataSource = modelos;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.CargarModelos(this.Filtrar(txtBusqueda.Text));
        }
    }
}
