using Microsoft.Maui.Controls;
using System;

namespace CadastroMateriaPrima
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

        private void OnFeitoButtonClicked(object sender, EventArgs e)
        {
            // Lógica para manipular o clique do botão feito
            string nomeMateriaPrima = NomeMateriaPrimaEntry.Text;
            string novoCodigo = NovoCodigoEntry.Text;
            string unidade = UnidadeEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string fornecedor = FornecedorEntry.Text;

            // Adicione aqui a lógica para salvar os dados ou realizar alguma ação
            DisplayAlert("Dados da Matéria Prima", 
                         $"Nome: {nomeMateriaPrima}\nNovo Código: {novoCodigo}\nUnidade: {unidade}\nQuantidade: {quantidade}\nFornecedor: {fornecedor}", 
                         "OK");
        }
    }
}
