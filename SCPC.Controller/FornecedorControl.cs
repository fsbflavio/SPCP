using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Collections;
using SPCP.Model;

namespace SPCP.Controller
{
    public class FornecedorControl
    {
        Fornecedor fornecedor = new Fornecedor();
        
        public void Incluir(FornecedorDTO fornecedorDTO)
        {
            fornecedor.Nome = fornecedorDTO.Nome;
            fornecedor.NumRua = fornecedorDTO.NumRua;
            fornecedor.Rua = fornecedorDTO.Rua;
            fornecedor.Situacao = fornecedorDTO.Situacao;
            fornecedor.Telefone = fornecedorDTO.Telefone;
            fornecedor.Uf = fornecedorDTO.Uf;
            fornecedor.Bairro = fornecedorDTO.Bairro;
            fornecedor.Celular = fornecedorDTO.Celular;
            fornecedor.Cep = fornecedorDTO.Cep;
            fornecedor.Cidade = fornecedorDTO.Cidade;
            fornecedor.Cnpj = fornecedorDTO.Cnpj;
            fornecedor.Complemento = fornecedorDTO.Complemento;
            fornecedor.Email = fornecedorDTO.Email;
            fornecedor.Incluir();

            return;
        }

        public DataTable Pesquisar(string nome)
        {
            return (fornecedor.Pesquisar(nome));
        }

        public DataTable CarregarDadosFornecedor(int id)
        {
            return (fornecedor.CarregarDadosFornecedor(id));
        }

        public void Alterar(FornecedorDTO fornecedorDTO)
        {
            fornecedor.Nome = fornecedorDTO.Nome;
            fornecedor.NumRua = fornecedorDTO.NumRua;
            fornecedor.Rua = fornecedorDTO.Rua;
            fornecedor.Situacao = fornecedorDTO.Situacao;
            fornecedor.Telefone = fornecedorDTO.Telefone;
            fornecedor.Uf = fornecedorDTO.Uf;
            fornecedor.Bairro = fornecedorDTO.Bairro;
            fornecedor.Celular = fornecedorDTO.Celular;
            fornecedor.Cep = fornecedorDTO.Cep;
            fornecedor.Cidade = fornecedorDTO.Cidade;
            fornecedor.Cnpj = fornecedorDTO.Cnpj;
            fornecedor.Complemento = fornecedorDTO.Complemento;
            fornecedor.Email = fornecedorDTO.Email;
            fornecedor.Incluir();

            return;
        }

        public bool Excluir(int Id)
        {
            return fornecedor.Excluir(Id);
        }

        public Fornecedor GetFornecedor()
        {
            return this.fornecedor;
        }

    }
}
