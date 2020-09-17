using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Tabelas;
using System;
using System.Collections.Generic;


namespace SaturnoManagementAPI.DTO
{
    public class ProdutoDTO
    {
        public ProdutoDTO (Produto produto)
        {
            this.Id = produto.Id;
            this.Nome = produto.Nome;
            this.Descricao = produto.Descricao;
            this.PrecoCompra = produto.PrecoCompra;
            this.Quantidade = produto.Quantidade;
            this.Permissao = produto.Permissao;
        }
        public ProdutoDTO()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoCompra { get; set; }
        public int Quantidade { get; set; }
        public PermissaoEnum Permissao { get; set; }

    }
}
