using SOLIDBahia.NET.OCP.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.OCP
{
    public class PagamentoCartaoCreditoOCP
    {
        public List<ITransactionValidator> Validadores { get; set; }

       
        public PagamentoCartaoCreditoOCP(List<ITransactionValidator> validadores)
        {
            Validadores = validadores;
        }

        //O objetivo da implementação é deixar esse método selado!
        //toda vez que houver uma mudança na regra de negócio, ninguém precisa mexer nele... 
        //É preciso apenas estender a implementação de validadores
        public bool ProcessarPagamento(Pessoa cliente, CartaoCredito dadosPagamento, decimal valorCompra)
        {
            
            foreach (var item in Validadores)
            {
                if (!item.Validate(cliente,dadosPagamento,valorCompra))
                    return false;
            }

            return true;
        }
    }
}
