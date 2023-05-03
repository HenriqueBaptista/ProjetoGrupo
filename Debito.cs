using projeto_pagamento;
namespace projeto_pagamento
{
    public class Debito : Cartao
    {
        private float saldo = 5000;

        public override void Pagar()
        {
            if (valor > saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo insuficiente");
                Console.ResetColor();
            }
            else if (saldo >= valor)
            {
                float saldoAtual = saldo - valor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pagamento de R${valor} realizado com sucesso. Novo saldo: R${saldoAtual}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro! Tente novamente");
                Console.ResetColor();
            }
        }
    }
}
