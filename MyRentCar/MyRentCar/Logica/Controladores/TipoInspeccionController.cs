using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class TipoInspeccionController
    {
        private MyRentCarContext db;
        public TipoInspeccionController()
        {
            this.db = new MyRentCarContext();
        }

        public List<TipoInspeccion> TraerTiposInspecciones()
        {
            return this.db.TiposInspecciones.ToList();
        }

        public bool ExisteTipoInspeccion(TipoInspeccion tipoInspeccion)
        {
            return this.db.TiposInspecciones.Any(t => t.Id == tipoInspeccion.Id);
        }

        public void Guardar(TipoInspeccion tipoInspeccion)
        {
            if (!ExisteTipoInspeccion(tipoInspeccion))
            {
                this.db.TiposInspecciones.Add(tipoInspeccion);
            }
            this.db.SaveChanges();
        }

       

    }
}
