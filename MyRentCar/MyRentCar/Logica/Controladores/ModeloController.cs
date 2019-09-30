using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class ModeloController
    {
        private MyRentCarContext db;

        public ModeloController()
        {
            this.db = new MyRentCarContext();
        }

        public List<Modelo> TraerModelos()
        {
            return db.Modelos.Include("Marca").ToList();
        }
    }
}
