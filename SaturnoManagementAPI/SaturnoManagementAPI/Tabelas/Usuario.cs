using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;

namespace SaturnoManagementAPI.Tabelas
{
    public class Usuario
    {

        public Usuario(UsuarioDTO usuario)
        {
            this.Nome = usuario.Nome;
            this.Sobrenome = usuario.Sobrenome;
            this.CPF = usuario.CPF;
            this.Email = usuario.Email;
            this.Senha = usuario.Senha;
            this.Permissao = usuario.Permissao;
        }
        public Usuario()
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
