using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using SPCP.Model;

namespace SPCP.Controller
{
    public class FichaProdutoControl
    {
        private FichaProduto ficha = new FichaProduto();

        public DataTable CarregaGrid(int id)
        {
            FichaProduto f = new FichaProduto();
            return (f.CarregaGrid(id));
        }

        public void Incluir(FichaProdutoDTO f)
        {
            ficha.IdItemEstoque = f.IdItemEstoque;
            ficha.IdProduto = f.IdProduto;
            ficha.Observacao = f.Observacao;
            ficha.Qtd = f.Qtd;

            ficha.Incluir();
        }

        public void SalvaGrid(ArrayList array)
        {
            foreach (FichaProdutoDTO fDto in array)
            {
                Incluir(fDto);
            }
        }

        public void Alterar(FichaProdutoDTO f)
        {
        }
    }
}
