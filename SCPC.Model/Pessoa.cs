using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPCP.Model
{
    public class Pessoa
    {
        public int Id { set; get; }
        public string Nome { get; set; }
        public string Cnpj;
        public string Rua;
        public string NumRua;
        public string Bairro;
        public string Complemento;
        public string Cep;
        public string Cidade;
        public string Uf;
        public string Situacao;
        public string Telefone;
        public string Celular;
        public string Email;

    }
}
