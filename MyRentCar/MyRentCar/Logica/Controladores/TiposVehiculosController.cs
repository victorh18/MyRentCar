using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class TiposVehiculosController
    {
        private MyRentCarContext db;

        public TiposVehiculosController()
        {
            this.db = new MyRentCarContext();
        }

        public List<TipoVehiculo> TraerTiposVehiculos()
        {
            return this.db.TiposVehiculos.ToList();
        }

        public void Guardar(TipoVehiculo _tipoVehiculo)
        {
            if (!db.TiposVehiculos.Any(t => t.Id == _tipoVehiculo.Id))
            {
                db.TiposVehiculos.Add(_tipoVehiculo);
            }
            db.SaveChanges();
        }

        public void Guardar()
        {
            db.SaveChanges();
            return;
        }

        public bool ExisteTipoVehiculo(TipoVehiculo _tipoVehiculo)
        {
            return db.TiposVehiculos.Any(t => t.Id == _tipoVehiculo.Id);
        }

        public void Remover(TipoVehiculo _tipoVehiculo)
        {
            db.TiposVehiculos.Remove(_tipoVehiculo);
        }


    }
}
