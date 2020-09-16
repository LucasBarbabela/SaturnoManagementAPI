using Newtonsoft.Json;
using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Tabelas;
using System.Collections.Generic;


namespace SaturnoManagementAPI.DTO
{
    public class ClienteDTO
    {
        public ClienteDTO(Cliente cliente)
        {
            this.Id = cliente.Id;
            this.Nome = cliente.Nome;
            this.CPF = cliente.CPF;
            this.Telefone = cliente.Telefone;
            this.Email = cliente.Email;
            this.Endereco = JsonConvert.DeserializeObject<IEnumerable<EnderecoDTO>>(cliente.Endereco);
            this.Permissao = cliente.Permissao;
        }

        public ClienteDTO()
        {

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }    
        public string Email { get; set; }
        public IEnumerable<EnderecoDTO> Endereco { get; set; }
        public PermissaoEnum Permissao { get; set; }

    }
}
