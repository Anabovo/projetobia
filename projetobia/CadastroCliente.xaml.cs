using System;
using Microsoft.Maui.Controls;

namespace projetobia
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

         private void VoltarDoCliente(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new ListaClientePage();
        }

         async void BotaoFeitoClicado(object sender, EventArgs args)
        {
            await DisplayAlert("Cliente salvo com sucesso!", "Dados Salvos!", "Ok");
            Application.Current.MainPage = new ListaClientePage();
            
        }
    }
}
