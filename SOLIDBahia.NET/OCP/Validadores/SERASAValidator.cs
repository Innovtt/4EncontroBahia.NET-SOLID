using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.OCP.Validadores
{
    public class SERASAValidator : ITransactionValidator
    {
        public bool Validate(Pessoa cliente, CartaoCredito dadosPagamento, decimal valorCompra)
        {
            if (SERASA.ClienteTemNomeSujo(cliente.Nome))
                return false;

            return true;
        }
    }
}
