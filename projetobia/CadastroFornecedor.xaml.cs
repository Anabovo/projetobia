using Microsoft.Maui.Controls;
using System;

namespace CadastroFornecedor
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void OnFeitoButtonClicked(object sender, EventArgs e)
        {
            // Lógica para manipular o clique do botão feito
            string nomeFornecedor = NomeFornecedorEntry.Text;
            string telefone = TelefoneEntry.Text;
            string email = EmailEntry.Text;
            string tipoFornecimento = TipoFornecimentoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string cnpj = CnpjEntry.Text;

            // Adicione aqui a lógica para salvar os dados ou realizar alguma ação
            DisplayAlert("Dados do Fornecedor", 
                         $"Nome: {nomeFornecedor}\nTelefone: {telefone}\nE-mail: {email}\nTipo de Fornecimento: {tipoFornecimento}\nQuantidade: {quantidade}\nCNPJ: {cnpj}", 
                         "OK");
        }
    }
}
