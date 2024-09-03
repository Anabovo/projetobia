using System.Collections.ObjectModel;
using Controles;
using Microsoft.Maui.Controls;
using projetobia;

namespace AppEquipe1
{
    public partial class EstoqueMateriaPrima : ContentPage
    {
        Controles.ControleMateriaPrima materiaPrimaControle = new Controles.ControleMateriaPrima();
        public EstoqueMateriaPrima()
        {
           InitializeComponent();

            Lista.ItemsSource = materiaPrimaControle.LerTodos();
        }

        private void VoltarClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void CadastroClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroMateriaPrima();        
        }
    }

    
}