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
                Application.Current.MainPage = new TelaInicial();
        }

         async void BotaoFeitoClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
