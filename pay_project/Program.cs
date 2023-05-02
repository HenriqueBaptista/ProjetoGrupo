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
PagamentoDebito debito = new PagamentoDebito();





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

    if (pagamento == "1")
    {
        bool sair = false;
        debito.SalvarCartao(sair);


        debito.Pagar(valorProduto, debito.restante, sair);
        reset = true;

    }
    else if (pagamento == "2")
    {

    }
    else if (pagamento == "3")
    {
        pay.valorCompra = valorProduto;

        pay.Registrar();

        reset = true;
    }
    else if (pagamento == "0")
    {
        pagar.Cancelar();

        reset = true;
    }
    else
    {
        Console.WriteLine($"Caractér inválido");
    }

} while (reset == false);





// Short Codes
