using AppMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProdutosListaPage : ContentPage
	{
        public Fornecedor FornecedorRecebido { get; set; }

        public ProdutosListaPage ()
		{
			InitializeComponent ();
		}

        public ProdutosListaPage(Fornecedor fornecedor) : this()
        {
            this.FornecedorRecebido = fornecedor;
            Title = $"Produtos da {fornecedor.Nome}";

            listViewProdutos.ItemsSource = fornecedor.Produtos;
        }
    }
}