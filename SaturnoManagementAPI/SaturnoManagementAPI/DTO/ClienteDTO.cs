using SaturnoManagementAPI.Enum;
using System.Collections.Generic;


namespace SaturnoManagementAPI.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }    
        public string Email { get; set; }
        public IEnumerable<EnderecoDTO> Endereco { get; set; }
        public PermissaoEnum Permissao { get; set; }

    }
}
