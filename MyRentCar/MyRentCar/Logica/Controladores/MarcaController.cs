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

        public void Editar(Marca marca)
        {
            db.Entry<Marca>(marca).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Guardar()
        {
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

        public Marca devolverMarca()
        {
            db.Marcas.Load();
            //db.Modelos.Load();
            return db.Marcas.FirstOrDefault();
        }
    }
}
