using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using SPCP.Model;

namespace SPCP.Controller
{
    public class FichaProdutoControl 
    {
        private FichaProduto ficha = new FichaProduto();

        public ArrayList GetFicha(int id)
        {
            ArrayList array = new ArrayList();
            ArrayList list = new ArrayList();
            FichaProdutoDTO fDTO;
            array = FichaProduto.GetFichaProduto(id);

            foreach (FichaProduto ficha in array)
            {
                try
                {
                    fDTO = new FichaProdutoDTO();
                    fDTO.Id = ficha.Id;
                    fDTO.Item.Id = ficha.itemEstoque.Id;
                    fDTO.Item.Descricao = ficha.itemEstoque.Descricao;
                    fDTO.Item.UnidadeMedida = ficha.itemEstoque.UnidadeMedida;

                    fDTO.Produto.Id = ficha.produto.Id;
                    fDTO.Produto.Descricao = ficha.produto.Descricao;

                    fDTO.Qtd = ficha.Qtd;
                    fDTO.Observacao = ficha.Observacao;

                    list.Add(fDTO);
                }
                catch
                {
 
                }
            }

            return list;
        }

        public void SalvaGrid(ArrayList array)
        {
            foreach (FichaProdutoDTO fDto in array)
            {
                if (fDto.Id == 0)
                    Incluir(fDto);
                else
                    Alterar(fDto);
            }
        }

        public void Incluir(FichaProdutoDTO f)
        {
            ficha.itemEstoque.Id = f.Item.Id;
            ficha.produto.Id = f.Produto.Id;
            ficha.Observacao = f.Observacao;
            ficha.Qtd = f.Qtd;

            ficha.Incluir();
        }

        public void Alterar(FichaProdutoDTO f)
        {
            ficha.itemEstoque.Id = f.Item.Id;
            ficha.produto.Id = f.Produto.Id;
            ficha.Observacao = f.Observacao;
            ficha.Qtd = f.Qtd;

            ficha.Alterar(f.Id);
        }
    }
}
