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
    public partial class frmBusquedaRentas : Form
    {
        private MyRentCarContext db;
        public int IdRenta;
        public frmBusquedaRentas()
        {
            InitializeComponent();
            this.db = new MyRentCarContext();
            List<RentaDTO> rentasConsultas = new List<RentaDTO>();
            foreach (Renta renta in this.db.Rentas.ToList())
            {
                rentasConsultas.Add(new RentaDTO(renta));
            }
            this.rentaDTOBindingSource.DataSource = rentasConsultas;
        }

        private void DgvRentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdRenta = (rentaDTOBindingSource.Current as RentaDTO).Renta.Id;
        }
    }
}
