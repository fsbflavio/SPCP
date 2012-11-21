using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SPCP.Model;

namespace SPCP.Controller
{
    public class FichaProdutoControl 
    {
        private FichaProduto ficha = new FichaProduto();

        public ArrayList GetFicha(int id)
        {
            ArrayList dt = new ArrayList();
            ArrayList list = new ArrayList();
            FichaProdutoDTO fDTO;
            dt = FichaProduto.GetFichaProduto(id);

            foreach (FichaProduto ficha in dt)
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

        public void SalvaGrid(ArrayList array, ArrayList excluidos)
        {
            foreach (FichaProdutoDTO fDto in array)
            {
                if (fDto.Id == 0)
                    Incluir(fDto);
                else
                    Alterar(fDto);
            }

            foreach (FichaProdutoDTO fDto in excluidos)
            {
                Excluir(fDto);
            }
        }

        public void Incluir(FichaProdutoDTO f)
        {
            ficha.itemEstoque.Id = f.Item.Id;
            ficha.produto.Id = f.Produto.Id;
            ficha.Observacao = f.Observacao;
            ficha.Qtd = f.Qtd;

            if (f.Produto.Id != 0)
                ficha.Incluir();
            else
                ficha.Incluir2();
        }

        public void Alterar(FichaProdutoDTO f)
        {
            ficha.itemEstoque.Id = f.Item.Id;
            ficha.produto.Id = f.Produto.Id;
            ficha.Observacao = f.Observacao;
            ficha.Qtd = f.Qtd;

            ficha.Alterar(f.Id);
        }

        public void Excluir(FichaProdutoDTO f)
        {
            ficha.Excluir(f.Id);
        }
    }
}
