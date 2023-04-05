using AppMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMobile.Services
{
    class FornecedoresService
    {
        public List<Fornecedor> Fornecedores { get; set; }


        public FornecedoresService() 
        {
            this.Fornecedores = new List<Fornecedor>() {
                new Fornecedor() { Nome = "Impacta", Endereco = "Av Paulista, 1009", Telefone = "11-3254-2200" },
                new Fornecedor() { Nome = "Microsoft", Endereco = "Av Nações Unidas, s/n", Telefone = "11-3003-000" },
                new Fornecedor() { Nome = "Oracle", Endereco = "Av Berrini, s/n", Telefone = "11-5005-0000" }
            };
        }
    }
}
