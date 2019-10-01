using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class EmpleadoController
    {
        public MyRentCarContext db;
        public EmpleadoController()
        {
            db = new MyRentCarContext();
        }

        public List<Empleado> TraerEmpleados()
        {
            return db.Empleados.ToList();
        }

        public bool ExisteEmpleado(Empleado empleado)
        {
            return db.Empleados.Any(e => e.Id == empleado.Id);
        }

        public void Guardar(Empleado empleado)
        {
            if (!ExisteEmpleado(empleado))
            {
                db.Empleados.Add(empleado);
            }

            db.SaveChanges();
        }

        public void Eliminar(Empleado empleado)
        {
            db.Empleados.Remove(empleado);
            db.SaveChanges();
        }
    }
}
