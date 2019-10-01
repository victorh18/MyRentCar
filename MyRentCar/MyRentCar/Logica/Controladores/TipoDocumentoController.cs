using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Logica.Controladores
{
    public class TipoDocumentoController
    {
        private MyRentCarContext db;

        public TipoDocumentoController()
        {
            this.db = new MyRentCarContext();
        }

        public bool ExisteTipoDocumento(TipoDocumento tipoDocumento)
        {
            return db.TiposDocumentos.Any(t => t.Id == tipoDocumento.Id);
        }

        public List<TipoDocumento> TraerTiposDocumentos()
        {
            return db.TiposDocumentos.ToList();
        }

        public void Guardar(TipoDocumento tipoDocumento)
        {
            if (!ExisteTipoDocumento(tipoDocumento))
            {
                db.TiposDocumentos.Add(tipoDocumento);
            }
            db.SaveChanges();
            return;
        }

        public void Remover(TipoDocumento tipoDocumento)
        {
            db.TiposDocumentos.Remove(tipoDocumento);
            return;
        }
    }
}
