namespace PetsCity
{
    public partial class Form1 : Form
    {
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // =======================================================================================
                // INSTANCIA(Criação do projeo na memória)
                // =======================================================================================

                Pedido pedido = new Pedido();

                // =======================================================================================
                //PROPRIEDADE(ATRIBUIÇÃO DE DADOS)
                //PEGAMOS O TEXT DAS CAIXAS TEXTBOX E CONVERTEMOS
                // =======================================================================================
                pedido.NomePet = txtNomePet.Text;
                pedido.PrecoServico = Convert.ToDouble(txtPrecoServico.Text);
                pedido.QuantidadeBanhosMensais = int.Parse(txtBanhosMensais.Text);
                pedido.IdadeAnimal = int.Parse(txtIdadeAnimal.Text);
                //UTILIZACAO DO OBJETO

                double desconto = pedido.CalcularDescontoFidelidade();
                double valorFinal = pedido.ValorFinalPacote();
                double parcela = pedido.CalcularValorParcela();
                bool brindeAprovado = pedido.ValidarSeBrinde();

                //EXIBIR OS DADOS FORMATADOS
                lblNomePet.Text = $"{pedido.NomePet.ToUpper()}";
                lblDescontoFidelidade.Text = $"R$ {desconto:N2}";
                lblStatus.Text = $"R$ {valorFinal:N2}";
                lblValorParcela.Text = $"3x de R$ {parcela:N2}";
                //Limpando campos
                txtNomePet.Clear();
                txtPrecoServico.Clear();
                txtBanhosMensais.Clear();
                txtIdadeAnimal.Clear();
                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Você ganhou um brinde surpresa!";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Blue;
                }
            }
            catch (FormatException)
            {
                // Tratamento simples caso o usuario digite texto onde deveria ser número
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                "Erro de Digitação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            }

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
