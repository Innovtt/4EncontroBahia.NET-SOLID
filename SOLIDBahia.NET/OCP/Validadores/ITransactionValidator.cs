using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.OCP.Validadores
{
    public interface ITransactionValidator
    {
        bool Validate(Pessoa cliente, CartaoCredito dadosPagamento, decimal valorCompra);
    }
}
