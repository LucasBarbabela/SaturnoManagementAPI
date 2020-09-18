using SaturnoManagementAPI.Configuração;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Interfaces;
using SaturnoManagementAPI.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Model
{
    public class UsuarioModel : IUsuario
    {
        private ERPContext contexto;
        public UsuarioModel(ERPContext _contexto)
        {
            contexto = _contexto;
        }

        public void Cadastrar(UsuarioDTO NovoUsuario)
        {
            Usuario Usuario = new Usuario(NovoUsuario);

            if (contexto.Usuarios.Select(x => x.Email == NovoUsuario.Email || x.CPF == NovoUsuario.CPF).Count() > 0)
                throw new Exception("O Email ou o CPF já estão cadastrados.");
            else
            {
                contexto.Usuarios.Add(Usuario);
                contexto.SaveChanges();
            }
           
        }

        public UsuarioDTO Login(UsuarioDTO Usuario)
        {
            UsuarioDTO retorno = new UsuarioDTO(contexto.Usuarios.Where(x => x.Email == Usuario.Email && x.Senha == Usuario.Senha).FirstOrDefault());
            if(retorno == null)
            {
                throw new Exception("Usuário ou senha inválidos, tente novamente..");
            }
            return retorno;
        }
    }
}
