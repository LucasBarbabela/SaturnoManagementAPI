using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Tabelas;

namespace SaturnoManagementAPI.DTO
{
    public class UsuarioDTO
    {
        public UsuarioDTO(Usuario usuario)
        {
            this.Id = usuario.Id;
            this.Nome = usuario.Nome;
            this.Sobrenome = usuario.Sobrenome;
            this.CPF = usuario.CPF;
            this.Email = usuario.Email;
            this.Senha = usuario.Senha;
            this.Permissao = usuario.Permissao;
        }
        public UsuarioDTO()
        {

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public PermissaoEnum Permissao { get; set; }

    }
}
