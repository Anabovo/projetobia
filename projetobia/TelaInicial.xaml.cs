using System;
using AppEquipe1;
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
            Application.Current.MainPage = new ListaClientePage();
        }

        private void SelecionaFornecedor(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new ListaFornecedorPage();
        }

        private void SelecionaProduto(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new CadastroProduto();
        }

        private void SelecionaMateriaPrima(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new EstoqueMateriaPrima();
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
