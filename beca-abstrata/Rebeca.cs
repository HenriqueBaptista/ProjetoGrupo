namespace ProjetoGrupo
{
    public abstract class Rebeca
    {
        //propriedades:
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public string Cvv { get; set; }

        //métodos:
        public abstract void Pagar();
        public void SalvarCartao()
        {
            Console.WriteLine($"Seu cartão foi salvo com sucesso!");
        }


    }
}