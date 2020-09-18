using SaturnoManagementAPI.Configuração;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Enum;
using SaturnoManagementAPI.Interfaces;
using SaturnoManagementAPI.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Model
{
    public class ProdutoModel : IProduto
    {

        private ERPContext contexto;
        public ProdutoModel(ERPContext _contexto)
        {
            contexto = _contexto;
        }
        public void CadastrarProduto(ProdutoDTO NovoProduto)
        {
            try
            {
                Produto produto = new Produto(NovoProduto);
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
            } 
            catch(Exception e)
            {
                throw new Exception("Ocorreu um erro no cadastro do produto. Mensagem: " + e);

            }

        }

        public ProdutoDTO Buscar(int IdProduto)
        {
            try
            {
                return new ProdutoDTO(contexto.Produtos.Where(x => x.Id == IdProduto).FirstOrDefault());

            }
            catch(Exception e)
            {
                throw new Exception("Ocorreu um erro em buscar o produto desejado. Mensagem: " + e);
            }
        }

        public List<ProdutoDTO> ListarPermissao(PermissaoEnum TipoProduto)
        {
            try
            {
                List<ProdutoDTO> retorno = new List<ProdutoDTO>();
                List<Produto> listaProduto = new List<Produto>();

                if (TipoProduto == PermissaoEnum.Administrador)
                    listaProduto = contexto.Produtos.ToList();
                else
                    listaProduto = contexto.Produtos.Where(x => x.Permissao == TipoProduto).ToList();

                foreach (Produto produto in listaProduto)
                {
                    retorno.Add(new ProdutoDTO(produto));
                }

                return retorno;
            } 
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro em Listar os produtos. Mensagem: " + e);
            }

        }

        public List<ProdutoDTO> ListarNome(string NomeProduto)
        {
            try
            {
                List<ProdutoDTO> retorno = new List<ProdutoDTO>();
                List<Produto> listaProduto = contexto.Produtos.Where(x => x.Nome.Contains(NomeProduto)).ToList();

                foreach (Produto produto in listaProduto)
                {
                    retorno.Add(new ProdutoDTO(produto));
                }
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro em Listar os produtos. Mensagem: " + e);
            }

        }

        public ProdutoDTO Deletar(int IdProduto)
        {
            try
            {
                ProdutoDTO retorno = new ProdutoDTO(contexto.Produtos.Remove(contexto.Produtos.Where(x => x.Id == IdProduto).FirstOrDefault()).Entity);
                contexto.SaveChanges();
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro em deletar o produo. Mensagem: " + e);
            }

        }

        public int Alterar(ProdutoDTO NovoProduto, int IdProduto)
        {
            try
            {
                Produto produtoAntigo = contexto.Produtos.SingleOrDefault(x => x.Id == IdProduto);

                if (produtoAntigo == null)
                    return 404;
                else
                {
                    produtoAntigo.Nome = NovoProduto.Nome;
                    produtoAntigo.Descricao = NovoProduto.Descricao;
                    produtoAntigo.Permissao = NovoProduto.Permissao;
                    produtoAntigo.PrecoCompra = NovoProduto.PrecoCompra;
                    produtoAntigo.Quantidade = NovoProduto.Quantidade;
                }
                   
                contexto.SaveChanges();

                return 201;
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro em alterar o cliente. Mensagem: " + e);
            }

        }
    }
}
