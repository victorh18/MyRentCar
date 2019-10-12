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
        private List<Empleado> empleados;
        public int IdEmpleado;

        public frmBusquedaEmpleado()
        {
            InitializeComponent();
            this.db = new MyRentCarContext();
            this.empleados = db.Empleados.ToList();
            this.CargarEmpleados(this.empleados);

        }

        private List<Empleado> Filtrar(string busqueda)
        {
            return this.empleados.Where(e => (e.Nombre + e.Cedula + e.TandaLaboral).Contains(busqueda)).ToList();
        }

        private void CargarEmpleados(List<Empleado> _empleados)
        {
            this.empleadoBindingSource.DataSource = _empleados;
        }

        private void DgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdEmpleado = (empleadoBindingSource.Current as Empleado).Id;
            this.Close();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.CargarEmpleados(this.Filtrar(txtBusqueda.Text));
        }
    }
}
