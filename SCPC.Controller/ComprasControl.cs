using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using SPCP.Model;

namespace SPCP.Controller
{
    public class ComprasControl
    {

        public Compras DTO2Compras(ComprasDTO c)
        {
            Compras compras = new Compras();
            ItemCompra it;

            compras.Id = c.Id;
            compras.Codigo = c.Codigo;
            compras.Fornecedor.Id = c.Fornecedor;
            compras.Status = c.Status;
            compras.Data = c.PrevisaoEntrega;
            compras.Observacoes = c.Observacoes;
            //compras.Item = c.ItemEstoque;

            foreach (ItemCompraDTO i in c.ItemCompra)
            {
                it = new ItemCompra();
                it.ICMS = i.ICMS;
                it.Id = i.Id;
                it.IPI = i.IPI;
                it.Observacao = i.Observacao;
                it.Qtd = i.Qtd;
                it.Compra.Id = compras.Id;

                it.ItemDeEstoque.Id = (int )i.IdItemDeEstoque;
                it.ValorUnitario = i.ValorUnitario;

                compras.Item.AddLast(it);
            }

            return compras;

        }

        public void Incluir(ComprasDTO p)
        {
            DTO2Compras(p).Incluir();
        }

        public void Alterar(ComprasDTO p)
        {
            Compras compra = DTO2Compras(p);
            compra.Alterar(p.Id);

            foreach (ItemCompra i in compra.Item)
            {
                if (i.Id == 0)
                    i.Incluir();
                else
                {
                    i.Alterar();
                }
            }
        }

        public void Excluir(ComprasDTO p)
        {
            Compras c = new Compras();
            c.Excluir(p.Id);
        }

        public LinkedList<ComprasDTO> getCompras()
        {
            LinkedList<Compras> compras = Compras.GetCompras();
            LinkedList<ComprasDTO> comprasDTO = new LinkedList<ComprasDTO>();
            ComprasDTO cDTO;

            foreach (Compras i in compras)
            {
                cDTO = new ComprasDTO();

                cDTO.Id = i.Id;
                cDTO.Fornecedor = i.Fornecedor.Id;
                cDTO.NomeFornecedor = i.Fornecedor.Nome;
                cDTO.PrevisaoEntrega = i.Data;
                cDTO.Status = i.Status;
                cDTO.Observacoes = i.Observacoes;
                comprasDTO.AddLast(cDTO);
            }
            return comprasDTO;
        }

        public ComprasDTO getCompra(int id)
        {
            Compras compra = Compras.GetCompra(id);
            ComprasDTO comprasDTO = new ComprasDTO();
            ItemCompraDTO itemCompraDTO;

            comprasDTO.Id = compra.Id;
            comprasDTO.Fornecedor = compra.Fornecedor.Id;
            comprasDTO.NomeFornecedor = compra.Fornecedor.Nome;
            comprasDTO.PrevisaoEntrega = compra.Data;
            comprasDTO.Status = compra.Status;
            comprasDTO.Observacoes = compra.Observacoes;

            foreach (ItemCompra i in compra.Item)
            {
                itemCompraDTO = new ItemCompraDTO();

                itemCompraDTO.Id = i.Id;
                itemCompraDTO.ICMS = i.ICMS;
                itemCompraDTO.IdItemDeEstoque = i.ItemDeEstoque.Id;
                itemCompraDTO.IPI = i.IPI;
                itemCompraDTO.Observacao = i.Observacao;
                itemCompraDTO.Qtd = i.Qtd;
                itemCompraDTO.ValorUnitario = i.ValorUnitario;

                comprasDTO.ItemCompra.AddLast(itemCompraDTO);
            }

            return comprasDTO;
        }
    }


}
