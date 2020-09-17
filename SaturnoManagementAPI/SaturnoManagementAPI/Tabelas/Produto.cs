using SaturnoManagementAPI.DTO;
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
        public Produto(ProdutoDTO produto)
        {
            this.Nome = produto.Nome;
            this.Descricao = produto.Descricao;
            this.PrecoCompra = produto.PrecoCompra;
            this.Quantidade = produto.Quantidade;
            this.Permissao = produto.Permissao;
        }

        public Produto()
        {

        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "Ultrapassado o limite de 60 caracteres.")]
        [MinLength(8, ErrorMessage = "Ultrapassado o limite mínimo de 8 caracteres.")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        public decimal PrecoCompra { get; set; }
        public int Quantidade { get; set; }
        [Required]
        public PermissaoEnum Permissao { get; set; }

    }
}
