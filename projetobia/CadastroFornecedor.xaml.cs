using Microsoft.Maui.Controls;
using System;

namespace projetobia
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

         private void VoltarDoFornecedor(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new ListaFornecedorPage();
        }

         private async void BotaoFeitoFnrClicado(object sender, EventArgs args)
        {
            DisplayAlert("Cliente salvo com sucesso!", "Dados Salvos!", "Ok");
            Application.Current.MainPage = new ListaFornecedorPage();
        }
    }
}
