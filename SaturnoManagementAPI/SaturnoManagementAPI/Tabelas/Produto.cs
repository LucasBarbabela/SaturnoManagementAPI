using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Tabelas
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "Ultrapassado o limite de 60 caracteres.")]
        [MinLength(8, ErrorMessage = "Ultrapassado o limite mínimo de 8 caracteres.")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        public double PrecoCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public IEnumerable<Cliente> ClienteComprado { get; set; }
        [Required]
        public PermissaoEnum Permissao { get; set; }

    }
}
