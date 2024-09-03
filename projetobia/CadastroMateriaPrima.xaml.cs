using Microsoft.Maui.Controls;
using System;

namespace projetobia
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

         private void VoltarDaMateriaPrima(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new TelaInicial();
        }

         async void BotaoFeitoMatPClicado(object sender, EventArgs args)
        {
            await DisplayAlert("Cliente salvo com sucesso!", "Dados Salvos!", "Ok");
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
