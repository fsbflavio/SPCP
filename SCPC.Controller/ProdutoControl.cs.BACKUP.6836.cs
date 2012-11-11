using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPCP.Model;

namespace SPCP.Controller
{
    public class ProdutoControl
    {
<<<<<<< HEAD:SCPC.Controller/ProdutoControl.cs
        public void Incluir(ProdutoDTO p)
=======
        public void Incluir(ProdutoDTO produtoDTO)
>>>>>>> Commit do Danilo:SCPC.Controler/ProdutoControl.cs
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

        public void Alterar(ProdutoDTO p)
        {
        }

    }
}
