using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPCP.Controller
{
    public class FichaProdutoDTO
    {
        public int Id {get; set;}
        public ItemEstoqueDTO Item{ get; set; }
        public ProdutoDTO Produto;
        public int Qtd { get; set; }
        public string Observacao { get; set; }

        public FichaProdutoDTO()
        {
            Id = 0;
            Item = new ItemEstoqueDTO();
            Produto = new ProdutoDTO();
            Qtd = 0;
            Observacao = string.Empty;
        }
    }
}
