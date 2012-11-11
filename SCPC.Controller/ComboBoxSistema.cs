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

        public static Object[] gruposItemEstoque()
        {
            Object[] grupos = new Object[] {
                new ComboBoxItem(1, "Oi"),
                new ComboBoxItem(2, "Bah")
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



    }
}
