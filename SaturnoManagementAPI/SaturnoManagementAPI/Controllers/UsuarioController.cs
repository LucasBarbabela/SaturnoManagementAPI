using Microsoft.AspNetCore.Mvc;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Controllers
{

    [ApiController]
    [Route("v1/Usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuario interfaceUsuario;

        public UsuarioController(IUsuario _interfaceUsuario)
        {
            interfaceUsuario = _interfaceUsuario;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public void Cadastrar(UsuarioDTO NovoUsuario)
        {
            interfaceUsuario.Cadastrar(NovoUsuario);
        }

        [HttpPost]
        [Route("Login")]
        public UsuarioDTO Login([FromBody]UsuarioDTO Usuario)
        {
            return interfaceUsuario.Login(Usuario);
        }

    }
}
