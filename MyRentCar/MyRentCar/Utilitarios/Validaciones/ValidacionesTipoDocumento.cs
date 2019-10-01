using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesTipoDocumento
    {
        public static bool ValidarTipoDocumento(TipoDocumento tipoDocumento)
        {
            if (tipoDocumento?.Descripcion == null)
            {
                return false;
            }
            return true;
        }
    }
}
