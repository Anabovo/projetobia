using Microsoft.Maui.Controls;

namespace CadastroPedido
{
    public partial class CadastroPedido : ContentPage
    {
        public CadastroPedido()
        {
            InitializeComponent();
            ConfirmarButton.Clicked += OnConfirmarButtonClicked;
        }

        private void OnConfirmarButtonClicked(object sender, EventArgs e)
        {
            // Implementar lógica do botão Confirmar aqui
            string codigoCliente = CodigoClienteEntry.Text;
            string telefone = TelefoneEntry.Text;
            string endereco = EnderecoEntry.Text;
            string codigoProduto = CodigoProdutoEntry.Text;
            string cor = CorEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string frete = FreteEntry.Text;
            string valorTotal = ValorTotalEntry.Text;

            // Exemplo: Exibir uma mensagem de confirmação
            DisplayAlert("Pedido Confirmado", "Seu pedido foi confirmado!", "OK");
        }
    }
}
