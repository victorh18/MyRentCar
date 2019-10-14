using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesDatos
    {
        public static bool ValidarCedula(string cedula)
        {
            int valorTotal = 0;
            int longitudCedula = cedula.Length;
            int[] multiplicadores = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (longitudCedula != 11)
            {
                return false;
            }

            for (int i = 0; i < longitudCedula; i++)
            {
                int calculo = Int32.Parse(cedula.Substring(i, 1)) * multiplicadores[i];
                if (calculo < 10)
                {
                    valorTotal += calculo;
                }
                else
                {
                    valorTotal += Int32.Parse(calculo.ToString().Substring(0, 1)) + Int32.Parse(calculo.ToString().Substring(1, 1));
                }
            }

            if (valorTotal % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
