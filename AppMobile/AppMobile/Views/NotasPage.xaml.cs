using System;
using System.Collections.Generic;
using System.IO;
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
        string arquivo = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData), "notas.txt");

		public NotasPage ()
		{
			InitializeComponent ();
            if (File.Exists(arquivo))
            {
                txtEditor.Text = File.ReadAllText(arquivo);
            }
		}

        private async void SalvarButton_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(arquivo, txtEditor.Text);
            await DisplayAlert("Informação", $"O arquivo foi armazenado em {arquivo}.", "OK");
        }

        private async void RemoverButton_Clicked(object sender, EventArgs e)
        {
            if (!File.Exists(arquivo))
            {
                await DisplayAlert("Informação", "Nenhum arquivo disponível.", "OK");
            }
            else
            {
                bool resposta = await DisplayAlert("Confirmação", "Gostaria de remover o arquivo?", "OK", "Cancelar");
                if (resposta)
                {
                    File.Delete(arquivo);
                    txtEditor.Text = string.Empty;
                }
            }
        }
    }
}