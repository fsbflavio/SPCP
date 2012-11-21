using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPCP.Controller
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public ProdutoDTO()
        {
            this.Descricao = string.Empty;
        }

        public override string ToString()
        {
            return this.Descricao;
        }
    }

}
