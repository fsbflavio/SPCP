using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SPCP.Model;

namespace SPCP.Controller
{
    public class ProdutoControl
    {
        private Produto produto = new Produto();

        public void Incluir(ProdutoDTO p)
        {
            produto.Codigo = p.Codigo;
            produto.Descricao = p.Nome;

            produto.Incluir();
        }

        public void Alterar(ProdutoDTO p)
        {
            produto.Codigo = p.Codigo;
            produto.Descricao = p.Nome;

            produto.Alterar(p.Id);
        }

        //public DataTable CarregarDados(int id)
        //{
        //    return produto.CarregarDados(id);
        //}
        
        public bool Excluir(int Id)
        {
            return produto.Excluir(Id);
        }

        public ProdutoDTO GetProduto(int id)
        {
            Produto p = Produto.GetProduto(id);
            ProdutoDTO produtoDTO = new ProdutoDTO();
            produtoDTO.Id = p.Id;
            produtoDTO.Codigo = p.Codigo;
            produtoDTO.Nome = p.Descricao;

            return produtoDTO;
        }

    }
}
