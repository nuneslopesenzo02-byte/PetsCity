
namespace PetsCity
{
    class Pedido
    {
        //ATRIBUTOS
        public string? NomePet { get; set; }

        public double PrecoServico { get; set; }

        public int QuantidadeBanhosMensais { get; set; }

        public int IdadeAnimal { get; set; }

        //MÉTODOS

        public double CalcularDescontoFidelidade()
        {
            double valorTotal = PrecoServico * QuantidadeBanhosMensais;

            if (QuantidadeBanhosMensais >= 5)
            {
                return valorTotal * 0.10;
            }
            return 0.0;
        }

        public double ValorFinalPacote()
        {
            double ValorFinalBruto = PrecoServico * QuantidadeBanhosMensais;
            double desconto = CalcularDescontoFidelidade();
            return ValorFinalBruto - desconto;
        }

        public double CalcularValorParcela()
        {
            return ValorFinalPacote() / 3.0;
        }
        public bool ValidarSeBrinde()
        {
            return (IdadeAnimal >= 8 && QuantidadeBanhosMensais >= 5) || (ValorFinalPacote() > 300.0);
        }

    }
}
