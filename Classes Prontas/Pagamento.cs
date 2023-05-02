using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGrupo
{
    public class Pagamento
    {
        private string horaCompra = DateTime.Now.ToString();
        public float valorCompra;
        public void Cancelar()
        {
            Console.WriteLine($"Compra cancelada !!");
        }
    }
}