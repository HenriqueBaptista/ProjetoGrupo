using ProjetoGrupo;

namespace ProjetoGrupo
{
    public class Boleto : Pagamento
    {
        public string ?CodigoDeBarras;

        public void Registrar(){
            Console.WriteLine($"Boleto gerado com sucesso!!!");
            Console.WriteLine($"Valor da compra = {this.valorCompra * 0.88}");
            
        }
    }
}