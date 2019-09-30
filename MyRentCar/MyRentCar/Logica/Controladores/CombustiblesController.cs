using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class CombustiblesController
    {
        private MyRentCarContext db;

        public CombustiblesController()
        {
            this.db = new MyRentCarContext();

        }

        public List<TipoCombustible> TraerCombustibles()
        {
            return db.TiposCombustibles.ToList();
        }

        public void Remover(TipoCombustible _combustible)
        {
            db.TiposCombustibles.Remove(_combustible);
        }

        public bool ExisteCombustible(TipoCombustible _combustible)
        {
            return db.TiposCombustibles.Any(c => c.Id == _combustible.Id);
        }

        public void Guardar(TipoCombustible tipoCombustible)
        {
            if (!ExisteCombustible(tipoCombustible))
            {
                db.TiposCombustibles.Add(tipoCombustible);
            }
            db.SaveChanges();
            return;
        }
    }
}
