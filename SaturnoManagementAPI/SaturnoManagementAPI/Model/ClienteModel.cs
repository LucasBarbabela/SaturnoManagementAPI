using Newtonsoft.Json;
using SaturnoManagementAPI.Configuração;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Interfaces;
using SaturnoManagementAPI.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
            try
            {
                Cliente ClienteInserido = new Cliente(NovoCliente);
                contexto.Clientes.Add(ClienteInserido);
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro no cadastro do cliente. Mensagem: " + e);
            }
        }

        public ClienteDTO BuscarCliente(int IdCliente)
        {
            try
            {
                return new ClienteDTO(contexto.Clientes.Where(x => x.Id == IdCliente).FirstOrDefault());
            } 
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro em buscar o cliente desejado. Mensagem: " + e);
            }
        }

        public List<ClienteDTO> ListarCliente(PermissaoEnum TipoCliente)
        {
            try
            {
                IEnumerable<Cliente> ClientesPermissao = contexto.Clientes.Where(x => x.Permissao == TipoCliente);
                List<ClienteDTO> ClienteDTOLista = new List<ClienteDTO>();
                foreach (Cliente cliente in ClientesPermissao)
                {
                    ClienteDTOLista.Add(new ClienteDTO(cliente));
                }
                return ClienteDTOLista;
            } 
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro em Listar os clientes. Mensagem: " + e);
            }

        }

        public ClienteDTO DeletarCliente(int IdCliente)
        {
            try
            {
                ClienteDTO retorno = new ClienteDTO(contexto.Clientes.Remove(contexto.Clientes.Where(x => x.Id == IdCliente).FirstOrDefault()).Entity);
                contexto.SaveChanges();
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro em deletar o cliente. Mensagem: " + e);
            }
        }

        public int AlterarCliente(ClienteDTO ClienteAtualizado, int IdCliente)
        {
            try
            {
                Cliente ClienteAntigo = contexto.Clientes.SingleOrDefault(x => x.Id == IdCliente);
                if (ClienteAntigo == null)
                    return 404;

                ClienteAntigo.Nome = ClienteAtualizado.Nome;
                ClienteAntigo.CPF = ClienteAtualizado.CPF;
                ClienteAntigo.Email = ClienteAtualizado.Email;
                ClienteAntigo.Endereco = JsonConvert.SerializeObject(ClienteAtualizado.Endereco);
                ClienteAntigo.Permissao = ClienteAtualizado.Permissao;
                ClienteAntigo.Telefone = ClienteAtualizado.Telefone;

                contexto.SaveChanges();

                return 201;
            }
            catch(Exception e)
            {
                throw new Exception("Ocorreu um erro em alterar o cliente. Mensagem: " + e);
            }
        }

    }
}
