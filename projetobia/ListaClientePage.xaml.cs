using Controles;
using Modelos;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace projetobia
{
    public partial class ListaClientePage : ContentPage
    {
        ControleCliente clienteControle=new ControleCliente();
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListaClientePage()
        {
            InitializeComponent();
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lista.ItemsSource=clienteControle.LerTodos();
        }

        private void VoltarClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void BuscarClicado(object sender, EventArgs e)
        {
            // Lógica para busca
        }

        private void CadastroClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroCliente();        
        }

        private void OnEdit(Cliente cliente)
        {
            // Lógica para edição
        }

        private void OnDelete(Cliente cliente)
        {
       
        }
    }

}