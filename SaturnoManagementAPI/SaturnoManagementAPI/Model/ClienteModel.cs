using Newtonsoft.Json;
using SaturnoManagementAPI.Configuração;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Interfaces;
using SaturnoManagementAPI.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Model
{
    public class ClienteModel : ICliente
    {
        private ERPContext contexto;
        public ClienteModel(ERPContext _contexto)
        {
            contexto = _contexto;
        }

        public void CadastrarCliente(ClienteDTO NovoCliente)
        {
            Cliente ClienteInserido = new Cliente()
            {
                Id = NovoCliente.Id,
                Nome = NovoCliente.Nome,
                CPF = NovoCliente.CPF,
                Telefone = NovoCliente.Telefone,
                Email = NovoCliente.Email,
                Endereco = JsonConvert.SerializeObject(NovoCliente.Endereco),
                Permissao = NovoCliente.Permissao
            };

            contexto.Clientes.Add(ClienteInserido);
            contexto.SaveChanges();
        }
    }
}
