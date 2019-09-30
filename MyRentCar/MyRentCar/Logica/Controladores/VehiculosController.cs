using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class VehiculosController
    {
        private MyRentCarContext db;
        
        public VehiculosController()
        {
            db = new MyRentCarContext();

        }

        public List<Vehiculo> TraerVehiculos()
        {
            return db.Vehiculos.ToList();
        }

        public bool ExisteVehiculo(Vehiculo vehiculo)
        {
            return db.Vehiculos.Any(v => v.Id == vehiculo.Id);

        }

        public void Guardar(Vehiculo vehiculo)
        {
            if (!ExisteVehiculo(vehiculo))
            {
                db.Vehiculos.Add(vehiculo);
            }

            db.SaveChanges();
        }

        public void Eliminar(Vehiculo vehiculo)
        {
            db.Vehiculos.Remove(vehiculo);
            db.SaveChanges();
            return;
        }

        public Modelo BuscarModelo(int id)
        {
            return db.Modelos.SingleOrDefault(m => m.Id == id);
        }

        public List<TipoCombustible> TraerCombustibles()
        {
            return db.TiposCombustibles.ToList();
        }

    }
}
