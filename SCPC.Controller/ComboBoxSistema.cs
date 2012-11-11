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
                new ComboBoxItem(2, "Materiais Secundários")
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
            Produto p = new Produto();

            ArrayList array = p.GetProdutos();

            return array;
        }

        public static ArrayList ItensEstoque()
        {
            ItemEstoque i = new ItemEstoque();
            ArrayList array = i.GetItensEstoque();
            return array;
        }


    }
}
