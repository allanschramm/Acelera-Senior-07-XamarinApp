using AppMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMobile.Services
{
    class FornecedoresService
    {
        public List<Fornecedor> Fornecedores { get; set; }

        public List<Produto> Produtos { get; set; }


        public FornecedoresService() 
        {
            this.Fornecedores = new List<Fornecedor>() {
                new Fornecedor() { Nome = "Impacta", Endereco = "Av Paulista, 1009", Telefone = "11-3254-2200" },
                new Fornecedor() { Nome = "Microsoft", Endereco = "Av Nações Unidas, s/n", Telefone = "11-3003-000" },
                new Fornecedor() { Nome = "Oracle", Endereco = "Av Berrini, s/n", Telefone = "11-5005-0000" }
            };

            this.Produtos = new List<Produto>()
            {
                new Produto() { Codigo = 10, Descricao = "Consultoria", Preco = 1000.0 },
                new Produto() { Codigo = 20, Descricao = "Compilador Java", Preco = 0 },
                new Produto() { Codigo = 30, Descricao = "Visual Studio", Preco = 100 },
                new Produto() { Codigo = 40, Descricao = "Curso Angular", Preco = 300 },
                new Produto() { Codigo = 50, Descricao = "SQL Server", Preco = 5000 },
                new Produto() { Codigo = 60, Descricao = "MySQL", Preco = 10 }
            };

            Fornecedores[0].Produtos.Add(Produtos[0]);
            Fornecedores[0].Produtos.Add(Produtos[3]);

            Fornecedores[1].Produtos.Add(Produtos[2]);
            Fornecedores[1].Produtos.Add(Produtos[4]);

            Fornecedores[2].Produtos.Add(Produtos[1]);
            Fornecedores[2].Produtos.Add(Produtos[5]);

        }
    }
}
