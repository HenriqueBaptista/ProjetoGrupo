using projeto_pagamento;
namespace projeto_pagamento
{
    public abstract class Cartao : Pagamento
    {
        //propriedades:
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public string CVV { get; set; }

        //funções:
        abstract public void Pagar();
        public void SalvarCartao()
        {
            string bandeira = "";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Digite o CVV do cartão:");
            Console.ResetColor();
            CVV = Console.ReadLine()!;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Digite o nome do titular do cartão:");
            Console.ResetColor();
            Titular = Console.ReadLine()!;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Digite o número do cartão:");
            Console.ResetColor();
            NumeroCartao = Console.ReadLine();
            Console.ResetColor();

            do
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@$"
 
     Selecione a bandeira do cartão        
                                           
   (1)- MasterCard                               
   (2)- Elo                          
   (3)- American Express                                  
   (4)- Visa                     
                                           
   (0)- Sair/Fechar                          

        ");

                Console.WriteLine($"Selecione a bandeira:");
                Console.ResetColor();

                bandeira = Console.ReadLine()!;
                switch (bandeira)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Bandeira selecionada: MasterCard");
                        Console.ResetColor();
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Bandeira selecionada: Elo");
                        Console.ResetColor();
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Bandeira selecionada: American Express");
                        Console.ResetColor();
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Bandeira selecionada: Visa");
                        Console.ResetColor();
                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Fechando... Obrigado!");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inexistente! Tente novamente: ");
                        Console.ResetColor();
                        bandeira = Console.ReadLine()!;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Informações do cartão salvas com sucesso!");
                Console.ResetColor();
                break;
            } while (bandeira != "0");
        }
    }
}