using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Interfaces
{
    public interface ICliente
    {
        public void CadastrarCliente(ClienteDTO NovoCliente);
        public ClienteDTO BuscarCliente(int IdCliente);
        public List<ClienteDTO> ListarCliente(PermissaoEnum TipoCliente);
        public ClienteDTO DeletarCliente(int IdCliente);
        public int AlterarCliente(ClienteDTO Cliente, int IdCliente);
    }
}
