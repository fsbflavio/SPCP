using System.Collections.Generic;
using SPCP.Controler;
using System;
using SPCP.Util;

namespace SPCP.Controler
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



    }
}
