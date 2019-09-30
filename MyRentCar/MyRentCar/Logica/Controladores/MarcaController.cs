using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;
using System.Data.Entity;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyRentCar.Logica.Controladores
{
    public class MarcaController
    {
        MyRentCarContext db;
        

        public MarcaController()
        {
            db = new MyRentCarContext();
        }
        public void Agregar(Marca marca)
        {
            db.Marcas.Add(marca);
            db.SaveChanges();
        }

        public void Guardar(Marca _marca)
        {
            Marca marcaDB = db.Marcas.Include(m => m.Modelos).SingleOrDefault(m => m.Id == _marca.Id);

            if (marcaDB != null)
            {
                db.Entry(_marca).State = EntityState.Modified;
                List<Modelo> modelos = db.Modelos.Where(m => m.IdMarca == _marca.Id).ToList();
                foreach (Modelo mod in modelos)
                {
                    if (!_marca.Modelos.Any(m => m.Id == mod.Id))
                    {
                        db.Modelos.Remove(mod);
                    }
                }

            }
            else
            {
                db.Entry(_marca).State = EntityState.Added;
            }

            db.SaveChanges();
            
        }

        public void Eliminar(Marca marca)
        {
            db.Marcas.Remove(marca);
            db.SaveChanges();
        }

        public Marca BuscarMarca(int idMarca)
        {
            var marca = db.Marcas.Find(idMarca);
            if (marca != null)
            {
                return marca;
            }
            return null;
        }

        public BindingList<Marca> TraerMarcas()
        {
            db.Marcas.Load();
            return db.Marcas.Local.ToBindingList();
        }

        public bool ExisteMarca(Marca _marca)
        {
            return db.Marcas.Any(m => m.Id == _marca.Id);
        }

        public List<TipoVehiculo> TraerTiposVehiculos()
        {
            return db.TiposVehiculos.ToList();
        }
        
    }
}
