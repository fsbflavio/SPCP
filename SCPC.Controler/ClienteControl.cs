using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPCP.Model;
using System.Data;
using Oracle.DataAccess.Client;

namespace SPCP.Controler
{
    public class ClienteControl
    {

        Cliente cliente = new Cliente();
        
        public void Incluir(ClienteDTO clienteDTO)
        {
            cliente.Nome = clienteDTO.Nome;
            cliente.NumRua = clienteDTO.NumRua;
            cliente.Rua = clienteDTO.Rua;
            cliente.Situacao = clienteDTO.Situacao;
            cliente.Telefone = clienteDTO.Telefone;
            cliente.Uf = clienteDTO.Uf;
            cliente.Bairro = clienteDTO.Bairro;
            cliente.Celular = clienteDTO.Celular;
            cliente.Cep = clienteDTO.Cep;
            cliente.Cidade = clienteDTO.Cidade;
            cliente.Cnpj = clienteDTO.Cnpj;
            cliente.Complemento = clienteDTO.Complemento;
            cliente.Email = clienteDTO.Email;
            cliente.Incluir();

            return;
        }

        public DataTable Pesquisar(string nome)
        {
            return (cliente.Pesquisar(nome));
        }

        public DataTable CarregarDadosCliente(int id)
        {
            return cliente.CarregarDadosCliente(id);
        }

        public void Alterar(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente();
            cliente.Id = clienteDTO.Id;
            cliente.Nome = clienteDTO.Nome;
            cliente.NumRua = clienteDTO.NumRua;
            cliente.Rua = clienteDTO.Rua;
            cliente.Situacao = clienteDTO.Situacao;
            cliente.Telefone = clienteDTO.Telefone;
            cliente.Uf = clienteDTO.Uf;
            cliente.Bairro = clienteDTO.Bairro;
            cliente.Celular = clienteDTO.Celular;
            cliente.Cep = clienteDTO.Cep;
            cliente.Cidade = clienteDTO.Cidade;
            cliente.Cnpj = clienteDTO.Cnpj;
            cliente.Complemento = clienteDTO.Complemento;
            cliente.Email = clienteDTO.Email;

            cliente.Alterar();
            return;
        }

        public bool Excluir(int Id)
        {
            return cliente.Excluir(Id);
        }

       

    }
}
