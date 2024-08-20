using Microsoft.Maui.Controls;

namespace projetobia
{
    public partial class CadastroProduto : ContentPage
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

         private void VoltarDoProduto(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new TelaInicial();
        }

         void BotaoFeitoProdClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
