namespace ProjetoGrupo
{
    public class PagamentoDebito : Cartao 
    {
        private float saldo = 3000;
        public float restante;


        public void Pagar(float x, float y, bool sair)
        {
          
             if (x > saldo)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                else if (saldo >= x)
                {
                    y = saldo - x;
                    Console.WriteLine($"Pagamento de R${x} realizado com sucesso. Novo saldo: R${y}");
                }
                  else if (sair == false)
            {
                this.Cancelar();
            }
                else
                {
                    Console.WriteLine($"Erro! Tente novamente");
                }
        }

        public override void Pagar()
        {
            throw new NotImplementedException();
        }
    }
}
