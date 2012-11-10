using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPCP.Model;

namespace SPCP.Controler
{
    public class ProdutoControl
    {
        public void Incluir(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto();
            produto.Codigo = produtoDTO.Codigo;
            produto.Descricao = produtoDTO.Nome;

            produto.Incluir();
        }

        public void Alterar()
        {
         //   Produto pro
        }
    }
}
