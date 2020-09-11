using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;

namespace SaturnoManagementAPI.DTO
{
    public class TransacaoDTO
    {
        public int Id { get; set; }
        public ClienteDTO Cliente { get; set; }
        public IEnumerable<ProdutoDTO> Produtos { get; set; }
        public double Preco { get; set; }
        public DateTime Data { get; set; }
        public TipoTransacaoEnum TipoTransacao { get; set; }
        public PermissaoEnum Permissao { get; set; }

    }
}
