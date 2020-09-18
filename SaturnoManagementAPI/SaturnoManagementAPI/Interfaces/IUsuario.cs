using SaturnoManagementAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Interfaces
{
    public interface IUsuario
    {
        public void Cadastrar(UsuarioDTO NovoUsuario);
        public UsuarioDTO Login(UsuarioDTO Usuario);
    }
}
