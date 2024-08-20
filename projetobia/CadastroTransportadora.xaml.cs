using System;
using Microsoft.Maui.Controls;

namespace projetobia
{
    public partial class CadastroTransportadora : ContentPage
    {
        public CadastroTransportadora()
        {
            InitializeComponent();
        }

         private void VolarDaTransportadora(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new TelaInicial();
        }

         void BotaoFeitoTraspClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
