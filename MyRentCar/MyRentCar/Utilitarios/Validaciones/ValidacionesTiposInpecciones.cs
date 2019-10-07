using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesTiposInpecciones
    {
        public static bool ValidarTipoInspecciones(TipoInspeccion tipoInspeccion)
        {
            if (tipoInspeccion.Descripcion == null)
            {
                return false;
            }
            return true;
        }
    }
}
