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
	public partial class NotasPage : ContentPage
	{
		public NotasPage ()
		{
			InitializeComponent ();
		}

        private void SalvarButton_Clicked(object sender, EventArgs e)
        {

        }

        private void RemoverButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}