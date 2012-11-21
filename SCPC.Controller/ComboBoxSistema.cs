using System.Collections.Generic;
using SPCP.Controller;
using System;
using System.Collections;
using SPCP.Util;
using SPCP.Model;


namespace SPCP.Controller
{
    public class ComboBoxSistema
    {

        public static ArrayList gruposItemEstoque()
        {
            ArrayList grupos = new ArrayList {
                new ComboBoxItem(1, "Materiais Diretos"),
                new ComboBoxItem(2, "Materiais Indiretos"),
                new ComboBoxItem(3, "Materiais Secundários")
            };
            
            return grupos;
        }

        public static Object[] unidadesMedida()
        {
            Object[] array = new Object[] {
                UnidadeMedida.Centimetro,
                UnidadeMedida.Metro,
                UnidadeMedida.Quilo
            };

            return array;
        }

        public static ArrayList Produtos()
        {
            ArrayList array = Produto.GetProdutos();

            //teste refactor aki
            ArrayList list = new ArrayList();
            ProdutoDTO pDTO;
            foreach (Produto p in array)
            {
                pDTO = new ProdutoDTO();
                pDTO.Id = p.Id;
                pDTO.Descricao = p.Descricao;
                pDTO.Codigo = p.Codigo;
                
                list.Add(pDTO);
            }

            return list;
        }

        public static ArrayList ItensEstoque()
        {
            ItemEstoque i = new ItemEstoque();
            ArrayList array = i.GetItensEstoque();


            //teste refactor aki

            ArrayList list = new ArrayList();
            ItemEstoqueDTO dto;
            foreach (ItemEstoque a in array)
            {
                dto = new ItemEstoqueDTO();
                dto.Descricao = a.Descricao;
                dto.EstoqueMinimo = a.EstoqueMinimo;
                dto.Id = a.Id;
                dto.UnidadeMedida = a.UnidadeMedida;
                dto.IdGrupoItemEstoque = a.GrupoItemEstoque.Id;
                list.Add(dto);
            }
            
            return list;
        }

        public static ArrayList GetFornecedores()
        {
            return Fornecedor.GetFornecedores();
        }

        public static ArrayList GetServicos()
        {
            return Servico.GetServicos();
        }

        public static ArrayList GetStatus()
        {
            return Status.GetServicos();
        }

    }
}
