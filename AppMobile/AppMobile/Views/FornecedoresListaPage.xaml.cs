using AppMobile.Models;
using AppMobile.Services;
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
	public partial class FornecedoresListaPage : ContentPage
	{
		public FornecedoresListaPage ()
		{
			InitializeComponent ();
			listViewFornecedores.ItemsSource = new FornecedoresService().Fornecedores;
		}

        private async void listViewFornecedores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			if(e.SelectedItem == null)
			{
				return;
			}

			var fornecedor = e.SelectedItem as Fornecedor;
			await Navigation.PushAsync(new ProdutosListaPage(fornecedor));

			((ListView)sender).SelectedItem = null;
        }
    }
}