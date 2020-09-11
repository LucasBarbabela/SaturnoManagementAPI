using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;


namespace SaturnoManagementAPI.DTO
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public IEnumerable<ClienteDTO> ClienteComprado { get; set; }
        public PermissaoEnum Permissao { get; set; }

    }
}
