using System;
using Microsoft.Maui.Controls;

namespace CadastroTransportadora
{
    public partial class CadastroTransportadora : ContentPage
    {
        public CadastroTransportadora()
        {
            InitializeComponent();
        }

        private void OnFeitoClicked(object sender, EventArgs e)
        {
            // Aqui você pode adicionar a lógica que deseja executar quando o botão for clicado.
            string nome = nomeEntry.Text;
            string telefone = telefoneEntry.Text;
            string email = emailEntry.Text;
            string endereco = enderecoEntry.Text;
            string cnpj = cnpjEntry.Text;
            string tipoFornecimento = tipoFornecimentoEntry.Text;

            // Exemplo: Mostrar uma mensagem com os dados inseridos
            DisplayAlert("Cadastro", $"Nome: {nome}\nTelefone: {telefone}\nEmail: {email}\nEndereço: {endereco}\nCNPJ: {cnpj}\nTipo de Fornecimento: {tipoFornecimento}", "OK");
        }
    }
}
