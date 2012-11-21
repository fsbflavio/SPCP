using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using SPCP.Model;

namespace SPCP.Controller
{
    public class ProdutoControl
    {
        private Produto produto = new Produto();

        public void Incluir(ProdutoDTO p)
        {
            produto.Codigo = p.Codigo;
            produto.Descricao = p.Descricao;

            produto.Incluir();
        }

        public void Alterar(ProdutoDTO p)
        {
            produto.Codigo = p.Codigo;
            produto.Descricao = p.Descricao;

            produto.Alterar(p.Id);
        }

        
        public bool Excluir(int Id)
        {
            return produto.Excluir(Id);
        }

        public ProdutoDTO GetProduto(int id) //subistituiu o CarregaDados
        {
            Produto p = Produto.GetProduto(id);
            ProdutoDTO produtoDTO = new ProdutoDTO();
            produtoDTO.Id = p.Id;
            produtoDTO.Codigo = p.Codigo;
            produtoDTO.Descricao = p.Descricao;

            return produtoDTO;
        }

        public ArrayList GetProdutos() //cria um array de dto .. porque não enviar direto um array de Produto?
        {
            ArrayList produtos;
            ArrayList produtosDTO = new ArrayList();

            produtos = Produto.GetProdutos();

            foreach (Produto p in produtos)
            {
                produtosDTO.Add(
                    new ProdutoDTO()
                    {
                        Id = p.Id,
                        Codigo = p.Codigo,
                        Descricao = p.Descricao
                    });
            }

            return produtosDTO;
        }

        public ArrayList GetProdutosByNome(string nome) //cria um array de dto .. porque não enviar direto um array de Produto?
        {
            ArrayList produtos;
            ArrayList produtosDTO = new ArrayList();

            produtos = Produto.GetProdutos();

            foreach (Produto p in produtos)
            {
                if (p.Descricao.Contains(nome))
                {
                    produtosDTO.Add(
                        new ProdutoDTO()
                        {
                            Id = p.Id,
                            Codigo = p.Codigo,
                            Descricao = p.Descricao
                        });
                }
            }

            return produtosDTO;
        }
    }
}
