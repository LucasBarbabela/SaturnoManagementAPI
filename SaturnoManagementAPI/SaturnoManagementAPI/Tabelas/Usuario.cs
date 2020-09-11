using SaturnoManagementAPI.Enum;

namespace SaturnoManagementAPI.Tabelas
{
    public class Usuario
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
