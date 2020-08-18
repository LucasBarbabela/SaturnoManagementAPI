using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Tabelas
{
    public class Transacao
    {
        [Key]
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        [Required]
        public Produto Produtos { get; set; }
        [Required]
        public double Preco { get; set; }
        public DateTime Data { get; set; }
        [Required]
        public TipoTransacaoEnum TipoTransacao { get; set; }
        [Required]
        public PermissaoEnum Permissao { get; set; }

    }
}
