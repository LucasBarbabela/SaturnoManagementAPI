using SaturnoManagementAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Interfaces
{
    public interface ICliente
    {
        public void CadastrarCliente(ClienteDTO NovoCliente);
    }
}
