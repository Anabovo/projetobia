using System;
using Microsoft.Maui.Controls;

namespace projetobia
{
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void SelecionaCliente(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new CadastroCliente();
        }

        private void SelecionaFornecedor(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new CadastroFornecedor();
        }

        private void SelecionaProduto(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new CadastroProduto();
        }

        private void SelecionaMateriaPrima(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new CadastroMateriaPrima();
        }

        private void SelecionaTransportadora(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new CadastroTransportadora();
        }

        private void SelecionaPedido(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new CadastroPedido();
        }

    }
}
