using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class InspeccionController
    {
        private MyRentCarContext db;
        public InspeccionController()
        {
            this.db = new MyRentCarContext();
        }
        public List<Inspeccion> TraerInspecciones()
        {
            return db.Inspecciones.ToList();
        }

        public bool ExisteInspeccion(Inspeccion inspeccion)
        {
            return db.Inspecciones.Any(i => i.Id == inspeccion.Id);

        }

        public void Guardar(Inspeccion inspeccion)
        {
            if (!ExisteInspeccion(inspeccion))
            {
                this.db.Inspecciones.Add(inspeccion);
            }
            this.db.SaveChanges();
        }

        public void Eliminar(Inspeccion inspeccion)
        {
            this.db.Inspecciones.Remove(inspeccion);
            return;
        }

        public T Buscar<T>(int Id) where T : class
        {
            return this.db.Set<T>().Find(Id);
        }


    }
}
