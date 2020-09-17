using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Controllers
{
    [ApiController]
    [Route("v1/Produto")]
    public class ProdutoController : ControllerBase
    {

        private readonly IProduto interfaceProduto;

        public ProdutoController(IProduto _interfaceProduto)
        {
            interfaceProduto = _interfaceProduto;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public void CadastrarProduto(ProdutoDTO NovoProduto)
        {
            interfaceProduto.CadastrarProduto(NovoProduto);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Buscar/{idProduto}")]
        public IActionResult Buscar(int idProduto)
        {
            ProdutoDTO retorno = interfaceProduto.Buscar(idProduto);
    
            if (retorno != null)
                return Ok(retorno);
            else
                return NotFound();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Listar/Permissao/{TipoProduto}")]
        public IActionResult ListarPermissao(PermissaoEnum TipoProduto)
        {
            List<ProdutoDTO> listaRetorno = interfaceProduto.ListarPermissao(TipoProduto);

            if (listaRetorno != null)
                return Ok(listaRetorno);
            else
                return NotFound();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Listar/Nome/{NomeProduto}")]
        public IActionResult ListarNome(string NomeProduto)
        {
            List<ProdutoDTO> listaRetorno = interfaceProduto.ListarNome(NomeProduto);
            if (listaRetorno != null)
                return Ok(listaRetorno);
            else
                return NotFound();
        }

        [HttpDelete]
        [Route("Deletar/{IdProduto}")]
        public ProdutoDTO Deletar(int IdProduto)
        {
            return interfaceProduto.Deletar(IdProduto);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        [Route("Alterar/{IdProduto}")]
        public IActionResult Alterar(ProdutoDTO NovoProduto, int IdProduto)
        {
            int retorno = interfaceProduto.Alterar(NovoProduto, IdProduto);
            if (retorno == 201)
                return Ok(NovoProduto);
            else
                return NotFound();
        }

    }
}
    