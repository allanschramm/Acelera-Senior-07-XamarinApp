using System;
using System.Collections.Generic;
using System.Text;

namespace AppMobile.Models
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public List<Produto> Produtos { get; set; }

        public Fornecedor() 
        {
            this.Produtos = new List<Produto>();
        }
    }
}
