using Microsoft.AspNetCore.Mvc;
using SaturnoManagementAPI.Configuração;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SaturnoManagementAPI.Controllers
{

    [ApiController]
    [Route("v1/Cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly ICliente interfaceCliente;

        public ClienteController (ICliente _interfaceCliente)
        {
            interfaceCliente = _interfaceCliente;
        }


        [HttpPost]
        [Route("Cadastrar")]
        public void CadastarCliente(ClienteDTO NovoCliente)
        {
            interfaceCliente.CadastrarCliente(NovoCliente);


        }

        [HttpGet]
        [Route("Buscar/{IdCliente}")]
        public ClienteDTO BuscarCliente(int IdCliente)
        {
            return new ClienteDTO();
        }

        [HttpGet]
        [Route("Listar/{TipoCliente}")] 
        public List<ClienteDTO> ListarCliente(PermissaoEnum TipoCliente)
        {
            return new List<ClienteDTO>();
        }

        [HttpDelete]
        [Route("Deletar/{IdCliente}")]
        public ClienteDTO ListarCliente(int IdCliente)
        {
            return new ClienteDTO();
        }

        [HttpPut]
        [Route("Alterar")]
        public ClienteDTO AlterarCliente(ClienteDTO Cliente)
        {
            return Cliente;
        }

    }
}
