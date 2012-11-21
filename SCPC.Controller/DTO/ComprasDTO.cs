using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SPCP.Controller
{
    public class ComprasDTO
    {
        public int Id {get; set;}
        public string Codigo { get; set; }
        public int Fornecedor;
        public string NomeFornecedor { get; set; }
        public DateTime PrevisaoEntrega { get; set; }
        public int Status;
        public string DescricaoStatus { get; set; }
        public string Observacoes { get; set; }

        public LinkedList<ItemCompraDTO> ItemCompra;

        public ComprasDTO()
        {
            ItemCompra = new LinkedList<ItemCompraDTO>();
        }
    }

}
