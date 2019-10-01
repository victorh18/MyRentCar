using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class ClienteController
    {
        private MyRentCarContext db;

        public ClienteController()
        {
            this.db = new MyRentCarContext();
        }

        public bool ExisteCliente(Cliente cliente)
        {
            return db.Clientes.Any(c => c.Id == cliente.Id);
        }

        public List<Cliente> TraerClientes()
        {
            return db.Clientes.ToList();

        }

        public void Guardar(Cliente cliente)
        {
            if (!ExisteCliente(cliente))
            {
                db.Clientes.Add(cliente);
            }
            db.SaveChanges();
            return;
        }

        public void Eliminar(Cliente cliente)
        {
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return;
        }

        public List<TipoDocumento> TraerTiposDocumentos()
        {
            return db.TiposDocumentos.ToList();
        }
    }
}
