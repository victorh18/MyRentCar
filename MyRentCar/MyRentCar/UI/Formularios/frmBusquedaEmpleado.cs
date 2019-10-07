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


namespace MyRentCar.UI.Formularios
{
    public partial class frmBusquedaEmpleado : Form
    {
        private MyRentCarContext db;
        public int IdEmpleado;

        public frmBusquedaEmpleado()
        {
            InitializeComponent();
            this.db = new MyRentCarContext();
            this.empleadoBindingSource.DataSource = db.Empleados.ToList();

        }

        private void DgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdEmpleado = (empleadoBindingSource.Current as Empleado).Id;
            this.Close();
        }
    }
}
