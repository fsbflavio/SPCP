using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPCP.Model;

namespace SPCP.Controller
{
    public class ProdutoControl
    {
<<<<<<< HEAD:SCPC.Controler/ProdutoControl.cs
        public void Incluir(ProdutoDTO produtoDTO)
=======
        public void Incluir(ProdutoDTO p)
>>>>>>> 795da7384ffb044e9f2f6f35b1adee54fe424df5:SCPC.Controller/ProdutoControl.cs
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
