using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.OCP.Validadores
{
    public class DadosPagamentoValidator : ITransactionValidator
    {
        public bool Validate(Pessoa cliente, CartaoCredito dadosPagamento, decimal valorCompra)
        {
            if (string.IsNullOrEmpty(dadosPagamento.NumeroCartao))
                return false;

            if (string.IsNullOrEmpty(dadosPagamento.CodigoSeguranca))
                return false;

            if (string.IsNullOrEmpty(dadosPagamento.NomeCartao))
                return false;

            return false;
        }
    }
}
