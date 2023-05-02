using ProjetoGrupo;

namespace ProjetoGrupo
{
    public class Boleto : Pagamento
    {
        
        Random codigoDeBarras = new Random();

        public void Registrar(){
            Console.WriteLine($"Boleto gerado com sucesso!!!");
            Console.WriteLine($"Valor da compra = {this.valorCompra * 0.88}");
            Console.WriteLine($"Código gerado {this.codigoDeBarras.Next()}");
            Console.WriteLine($"Data de vencimento {this.Data}");





















            
        }
    }
}