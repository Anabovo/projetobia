using Microsoft.Maui.Controls;

namespace projetobia
{
    public partial class CadastroPedido : ContentPage
    {
        public CadastroPedido()
        {
            InitializeComponent();
        }

        private void VoltarDoPedido(object sender, EventArgs e)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new TelaInicial();
        }

         void BotaoFeitoPedClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
