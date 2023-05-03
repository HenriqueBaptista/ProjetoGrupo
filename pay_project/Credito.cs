
namespace ProjetoGrupo
{
    public class Credito : Cartao
    {
        private float limite = 5000;
        private bool repetição = true;
        public override void Pagar(float x)
        {
            do
            {


                if (x < limite)
                {
                    Console.WriteLine($"O valor a ser pago é de: {x}");

                    Console.WriteLine($"Quer parcelar ? s/n");
                    Char parcelamento = Char.Parse(Console.ReadLine()!.ToUpper());

                    if (parcelamento == 'S')
                    {
                        Console.WriteLine($"Em quantas parcelas? (1-12)");
                        int parcelas = int.Parse(Console.ReadLine()!);

                        if ((parcelas <= 6) && (parcelas > 0))
                        {
                            Console.WriteLine(@$"
então ficará: 
{parcelas} parcelas de {(x / parcelas) + Math.Round((x * 0.05), 2)} por mês
                        ");
                        }
                        
                        else if ((parcelas > 6) && (parcelas <= 12))
                        {
                           Console.WriteLine(@$"
então ficará: 
{parcelas} parcelas de {(x / parcelas) + Math.Round((x * 0.08), 2)} por mês
                        "); 
                        }
                    }
                    else if (parcelamento == 'N')
                    {
                        Console.WriteLine($"Transação concluída");
                        repetição = true;
                    }
                    else
                    {
                        Console.WriteLine($"Opção inválida");
                    }
                }
                else
                {
                    Console.WriteLine($"O limite é isuficiente!");
                }

            } while (repetição != true);
        }
    }
}