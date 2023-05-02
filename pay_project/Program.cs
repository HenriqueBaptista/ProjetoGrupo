// Criar um menu onde o usuário poderá inserir um preço de um produto.
// Depois da inserção, pedir a forma de pagamento, sendo elas:

// . Boleto - Artur
// . Cartão - Rebeca

// Se a escolha for Cartão, acessar as escolhas:

// . Débito - Lucca
// . Crédito - Felipe

using ProjetoGrupo;

Pagamento pagar = new Pagamento();
Boleto bolet = new Boleto();



Console.WriteLine($"Digite o nome do produto: ");
string produto = Console.ReadLine()!;
Br();
Console.WriteLine($"Digite o preço do produto: ");
float preco = int.Parse(Console.ReadLine()!);

Console.WriteLine(@$"
Digite a forma de pagamento: 

[1] Cartão
[2] Boleto
");
string pagamento = Console.ReadLine()!;

switch (pagamento)
{
    case "1":
        break;
    case "2":
        break;
    default:
    Console.WriteLine($"Caractér inválido");
    
        break;
}






// Short Codes
static string Br()
{
    Console.WriteLine($"");
    return "";
}