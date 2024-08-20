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

         void BotaoFeitoMatPClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
