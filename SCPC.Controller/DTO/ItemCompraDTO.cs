using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPCP.Controller
{
    public class ItemCompraDTO
    {
        public int Id { get; set; }
        public int? IdItemDeEstoque { get; set; }
        public float ICMS { get; set; }
        public float IPI {get; set;}
        public int Qtd{get; set;}
        public float ValorUnitario { get; set; }
        public string Observacao { get; set; }
        public int IdCompra;


        //public ItemCompraDTO()
        //{
        //    //this.IdItemDeEstoque = DBNull.Value;
        //}

    }
}
