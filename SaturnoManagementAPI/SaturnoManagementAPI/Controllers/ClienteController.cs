using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaturnoManagementAPI.Configuração;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Interfaces;
using System;
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

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Buscar/{IdCliente}")]
        public IActionResult BuscarCliente(int IdCliente)
        {
            ClienteDTO retorno = interfaceCliente.BuscarCliente(IdCliente);
            if (retorno != null)
                return Ok(retorno);
            else
                return NotFound();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Listar/{TipoCliente}")] 
        public IActionResult ListarCliente(PermissaoEnum TipoCliente)
        {
            List<ClienteDTO> retorno = interfaceCliente.ListarCliente(TipoCliente);

            if (retorno != null)
                return Ok(retorno);
            else
                return NotFound();
        }

        [HttpDelete]
        [Route("Deletar/{IdCliente}")]
        public ClienteDTO DeletarCliente(int IdCliente)
        {
            return interfaceCliente.DeletarCliente(IdCliente);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        [Route("Alterar/{IdCliente}")]
        public IActionResult AlterarCliente([FromBody]ClienteDTO ClienteAlterar, int IdCliente)
        {
            int retorno = interfaceCliente.AlterarCliente(ClienteAlterar, IdCliente);

            if (retorno == 201)
                return Ok(ClienteAlterar);
            else
                return NotFound();
        }

    }
}
