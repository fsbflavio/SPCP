using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPCP.Model;
using System.Data;
using SPCP.Util;

namespace SPCP.Controller
{
    public class ItemEstoqueControl
    {
        ItemEstoque itemEstoque = new ItemEstoque();

        public void Incluir(ItemEstoqueDTO itemEstoqueDTO)
        {
            itemEstoque.Descricao = itemEstoqueDTO.Descricao;
            itemEstoque.UnidadeMedida = itemEstoqueDTO.UnidadeMedida;
            itemEstoque.GrupoItemEstoque = GrupoItemEstoque.FindById(itemEstoqueDTO.IdGrupoItemEstoque);
            itemEstoque.EstoqueMinimo = itemEstoqueDTO.EstoqueMinimo;
         
            itemEstoque.incluir();
        }

        public DataTable Pesquisar(string nome)
        {
            return (itemEstoque.pesquisar(nome));
        }

        public DataTable CarregarDadosItemEstoque(int id)
        {
            return itemEstoque.CarregarDadosItemEstoque(id);
        }

        public void Alterar(ItemEstoqueDTO itemEstoqueDTO)
        {

        }

        public bool Excluir(int Id)
        {
            return itemEstoque.excluir(Id);
        }
    }
}
