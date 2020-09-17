using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Interfaces
{
    public interface IProduto
    {
        public void CadastrarProduto(ProdutoDTO NovoProduto);
        public ProdutoDTO Buscar(int idProduto);
        public List<ProdutoDTO> ListarPermissao(PermissaoEnum TipoProduto);
        public List<ProdutoDTO> ListarNome(string NomeProduto);
        public ProdutoDTO Deletar(int idProduto);
        public int Alterar(ProdutoDTO NovoProduto, int IdProduto);


    }
}
