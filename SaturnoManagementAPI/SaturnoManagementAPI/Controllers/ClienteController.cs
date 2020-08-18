using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaturnoManagementAPI.Configuração;
using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Tabelas;

namespace SaturnoManagementAPI.Controllers
{

    [ApiController]
    [Route("v1/Cliente")]
    public class ClienteController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public int Get([FromServices] ERPContext context)
        {
            Endereco a = new Endereco();
            a.Bairro = "2312323";
            a.CEP = "30535610";
            a.Cidade = "alola";
            a.Estado = "MG";
            a.Numero = 23;
            a.Permissao = PermissaoEnum.Colaborador;
            context.Enderecos.Add(a);
            context.SaveChanges();
            return context.Enderecos.Last().ID;
        }
    }
}
