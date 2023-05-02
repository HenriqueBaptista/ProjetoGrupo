namespace ProjetoGrupo
{
    public abstract class Cartao : Pagamento
    {
        public string ?Bandeira { get; set; }
        public string ?NumeroCartao { get; set; }
        public string ?Titular { get; set; }
        public string ?CVV { get; set; }


        abstract public void Pagar();
        public void SalvarCartao(bool sair)
        {
            string bandeira = "";

            Console.WriteLine("Digite o CVV do cartão:");
            this.CVV = Console.ReadLine()!;

            Console.WriteLine("Digite o nome do(a) titular do cartão:");
            this.Titular = Console.ReadLine()!;

            Console.WriteLine("Digite o número do cartão:");
            this.NumeroCartao = Console.ReadLine()!;

            do
            {

                Console.WriteLine(@$"

     Selecione a bandeira do cartão        
                                           
   (1)- Visa                                 
   (2)- MasterCard                           
   (3)- American Express                            
   (4)- Elo                   
   (0)- Cancelar                                     
                       
 
        ");

                Console.WriteLine($"Selecione a bandeira:");

                bandeira = Console.ReadLine()!;

                switch (bandeira)
                {
                    case "1":
                        Console.WriteLine($"Bandeira selecionada: Visa");
                        break;

                    case "3":
                        Console.WriteLine($"Bandeira selecionada: MasterCard");
                        break;

                    case "2":
                        Console.WriteLine($"Bandeira selecionada: Elo");
                        break;

                    case "4":
                        Console.WriteLine($"Bandeira selecionada: American Express");

                        break;
                        case "0":
                        Environment.Exit(0);
                        Console.WriteLine($"{this.Cancelar}");
                        break;


                    default:
                        Console.WriteLine($"Opção inexistente! Tente novamente: ");
                        ;
                        bandeira = Console.ReadLine()!;
                        break;
                }
                break;
            } while (bandeira != "0");

        }

    }
}