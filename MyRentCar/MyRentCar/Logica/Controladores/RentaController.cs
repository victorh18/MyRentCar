using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;


namespace MyRentCar.Logica.Controladores
{
    public class RentaController
    {
        private MyRentCarContext db;

        public RentaController()
        {
            this.db = new MyRentCarContext();
        }

        public List<Renta> TraerRentas()
        {
            return db.Rentas.ToList();
        }

        public bool ExisteRenta(Renta renta)
        {
            return db.Rentas.Any(r => r.Id == renta.Id);
        }

        public void Guardar(Renta renta)
        {
            if (!ExisteRenta(renta))
            {
                db.Rentas.Add(renta);
            }
            db.SaveChanges();
            return;
        }

        public void Eliminar(Renta renta)
        {
            db.Rentas.Remove(renta);
            db.SaveChanges();
            return;
        }

        //public Empleado BuscarEmpleado(int id)
        //{
        //    return db.Empleados.Find(id);
        //}

        //public Modelo BuscarModelo(int id)
        //{
        //    return db.Modelos.Find(id);
        //}

        public T Buscar<T>(int id) where T : class
        {
            return db.Set<T>().Find(id);
        }
    }
}
