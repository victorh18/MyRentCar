using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.DTOs
{
    public class ClienteDTO
    {
        private Cliente cliente;
        public ClienteDTO(Cliente _cliente)
        {
            this.cliente = _cliente;
        }

        public string NombreCliente
        {
            get
            {
                return cliente.Nombre;
            }
        }
        public string TipoDocumento
        {
            get
            {
                return cliente.TipoDocumento.Descripcion;
            }
        }

        public string NumeroDocumento
        {
            get
            {
                return cliente.NumeroDocumento;
            }
        }

        public bool Estado
        {
            get
            {
                return cliente.Estado ?? false;
            }
        }

    }
}
