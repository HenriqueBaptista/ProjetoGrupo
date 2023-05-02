using ProjetoGrupo;

namespace ProjetoGrupo
{
    public class Boleto
    {
        Pagamento pay = new Pagamento();
        public string CodigoDeBarras;

        public void Registrar(){
            Console.WriteLine($"Boleto gerado com sucesso!!!");
            Console.WriteLine($"Valor da compra = {pay.valorCompra * 0.88}");
            
        }
    }
}