﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OpcoesPage : ContentPage
	{
		public OpcoesPage ()
		{
			InitializeComponent ();
		}

        private void btnFornecedores_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync (new FornecedoresListaPage ());
        }
    }
}