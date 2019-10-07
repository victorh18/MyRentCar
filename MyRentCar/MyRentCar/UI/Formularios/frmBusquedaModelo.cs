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
        private ModeloController controller; 
        public int IdModelo;
        public frmBusquedaModelo()
        {
            InitializeComponent();
            controller = new ModeloController();
            List<ModeloDTO> modelos = new List<ModeloDTO>();
            foreach (var m in controller.TraerModelos())
            {
                modelos.Add(new ModeloDTO(m));
            }

            modeloDTOBindingSource.DataSource = modelos;
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
    }
}
