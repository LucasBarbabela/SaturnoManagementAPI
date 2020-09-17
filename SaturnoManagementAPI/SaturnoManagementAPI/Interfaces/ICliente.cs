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
        public void Cadastrar(ClienteDTO NovoCliente);
        public ClienteDTO Buscar(int IdCliente);
        public List<ClienteDTO> Listar(PermissaoEnum TipoCliente);
        public ClienteDTO Deletar(int IdCliente);
        public int Alterar(ClienteDTO Cliente, int IdCliente);
    }
}
