// Criar um menu onde o usuário poderá inserir um preço de um produto.
// Depois da inserção, pedir a forma de pagamento, sendo elas:

// . Boleto - Artur
// . Cartão - Rebeca

// Se a escolha for Cartão, acessar as escolhas:

// . Débito - Lucca
// . Crédito - Felipe

using ProjetoGrupo;

bool reset = false;

Pagamento pagar = new Pagamento();
Boleto pay = new Boleto();






Console.WriteLine($"Digite o preço do produto: ");
int valorProduto = int.Parse(Console.ReadLine()!);

do
{
    Console.WriteLine(@$"
Digite a forma de pagamento: 

[1] Débito
[2] Crédito
[3] Boleto
[0] Cancela
");
    string pagamento = Console.ReadLine()!;

    switch (pagamento)
    {
        case "1":

            break;

        case "2":
            break;

        case "3":
            pay.valorCompra = valorProduto;

            pay.CodigoDeBarras = "...";
            pay.Registrar();

            reset = true;
            break;

        case "0":
            pagar.Cancelar();

            reset = true;
            break;

        default:
            Console.WriteLine($"Caractér inválido");
            break;
    }
} while (reset == false);





// Short Codes
