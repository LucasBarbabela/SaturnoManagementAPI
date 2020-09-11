using SaturnoManagementAPI.Enum;

namespace SaturnoManagementAPI.DTO
{
    public class UsuarioDTO
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public PermissaoEnum Permissao { get; set; }

    }
}
