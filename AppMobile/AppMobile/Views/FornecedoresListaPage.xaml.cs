﻿using AppMobile.Services;
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
	}
}