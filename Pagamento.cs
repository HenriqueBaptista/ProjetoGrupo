using projeto_pagamento;
namespace projeto_pagamento
{
    public class Pagamento
    {
        // Propriedades:
        public float valor;
        public DateTime date1 { get; private set; } = DateTime.Now;

        //Métodos

        public string Cancelar()
        {
            return "Seu pagamento foi cancelado! Por favor tente novamente!";
        }
    }
}
