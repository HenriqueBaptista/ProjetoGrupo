namespace ProjetoGrupo
{
    public class Pagamento
    {
        public DateTime Data{get; private set;}
        public float valorCompra;
        public void Cancelar()
        {
            Console.WriteLine($"Compra cancelada !!");
        }
    }
}