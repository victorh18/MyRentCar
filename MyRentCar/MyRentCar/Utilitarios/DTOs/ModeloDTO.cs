using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.DTOs
{
    public class ModeloDTO
    {
        private Modelo modelo;
        public ModeloDTO(Modelo _modelo)
        {
            this.modelo = _modelo;
        }

        public string NombreModelo
        {
            get
            {
                return modelo.Descripcion;
            }
        }

        public bool EstadoModelo
        {
            get
            {
                return modelo.Estado ?? false;
            }
        }

        public string NombreMarca
        {
            get
            {
                return modelo.Marca.Descripcion;
            }
        }

        public Modelo Modelo
        {
            get
            {
                return modelo;
            }
        }
    }
}
