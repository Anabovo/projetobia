
using Controles;
using Modelos;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace projetobia
{
    public partial class ListaFornecedorPage : ContentPage
    {
        ControleFornecedor fornecedorControle = new ControleFornecedor();
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListaFornecedorPage()
        {
            InitializeComponent();
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaFornecedor.ItemsSource = fornecedorControle.LerTodos();
        }


        private void VoltarClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Lógica para busca
        }

        private void CadastrarClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroFornecedor();
        }

        private void OnEdit(Fornecedor fornecedor)
        {
            // Lógica para edição
        }

        private void OnDelete(Fornecedor fornecedor)
        {
            //Fornecedores.Remove(fornecedor);
        }
    }


}