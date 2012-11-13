using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPCP.Model;
using System.Data;
using SPCP.Util;

namespace SPCP.Controller
{
    public class ItemEstoqueDTO
    {
        public int Id {get; set;}
        public String Descricao {get; set;}
        public int EstoqueMinimo;
        public UnidadeMedida UnidadeMedida;
        public int IdGrupoItemEstoque;

        public override string ToString()
        {
            return Descricao;
        }
    }
}
