using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        public T Buscar<T>(int id) where T : class
        {
            return db.Set<T>().Find(id);
        }

        public List<T> Traer<T>() where T : class
        {
            return db.Set<T>().ToList();
        }

        public List<Renta> Filtrar(List<Expression<Func<Renta, bool>>> filtros)
        {
            var rentas = db.Rentas.Where(r => 1 == 1);
            foreach (var condicion in filtros)
            {
                rentas = rentas.Where(condicion);
            }
            return rentas.ToList();
        }
    }
}
