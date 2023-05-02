
namespace ProjetoGrupo
{
    public class Credito : Cartao
    {
        private float limite = 5000;
        public override void Pagar()
        {
            if (ValorCompra < limite)
            {
                Console.WriteLine($"O valor a ser pago é de {ValorCompra}");
                
                
            }
        }
    }
}