using projeto_pagamento;

//variáveis:
string opcao = "";
Boleto PagarBoleto = new Boleto();
Pagamento Pague = new Pagamento();
Debito Debito = new Debito();
Credito Credito = new Credito();

//função menú:
void menu()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine(@$"
 
     PROJETO PAGAMENTO - Escolha sua forma de pagamento:     
                                           
   (1)- Boleto                               
   (2)- Crédito                              
   (3)- Débito                               
                                           
   (0)- Sair/Fechar                          

");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"Seleciona a opção desejada: ");
    Console.ResetColor();
    opcao = Console.ReadLine()!;
}

do
{
    menu();
    switch (opcao)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            Console.ResetColor();
            PagarBoleto.valor = float.Parse(Console.ReadLine()!);

            Console.WriteLine(PagarBoleto.CodigoDeBarras());
            PagarBoleto.Registrar();
            break;

        case "2":
            Debito.SalvarCartao();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            Credito.valor = float.Parse(Console.ReadLine()!);
            Console.ResetColor();

            Credito.Pagar();
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            Console.ResetColor();
            Debito.valor = float.Parse(Console.ReadLine()!);
            Debito.SalvarCartao();
            Debito.Pagar();
            break;

        case "0":
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inexistente! Tente novamente: ");
            Console.ResetColor();
            opcao = Console.ReadLine()!;
            break;
    }

} while (opcao != "0");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(Pague.Cancelar());
Console.ResetColor();
