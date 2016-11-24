using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.OCP
{
    public class PagamentoCartaoCredito
    {
        //REQUISITOS: 
        //Validar nome está preenchido
        //Vaidar numero cartao está preenchido
        //Validar codigo de segurança está preenchido
        public bool ProcessarPagamento(Pessoa cliente, CartaoCredito dadosPagamento, decimal valorCompra)
        {

            if (string.IsNullOrEmpty(dadosPagamento.NumeroCartao))
                return false;

            if (string.IsNullOrEmpty(dadosPagamento.CodigoSeguranca))
                return false;

            if (string.IsNullOrEmpty(dadosPagamento.NomeCartao))
                return false;

            return true;
        }

        //VIOLAÇAO DO OCP OCORRE NO MOMENTO DA MUDANÇA DE REQUISITO

        //NOVO REQUISITO: ANTI-FRAUDE

        //REQUISITOS V2: 
        //Validar nome está preenchido
        //Vaidar numero cartao está preenchido
        //Validar codigo de segurança está preenchido
        //Valor da compra ultrapassa R$ 1.000 deve ir pra analise de risco
        //Verificar nome do cliente no SERASA
        public bool ProcessarPagamentoV2(Pessoa cliente, CartaoCredito dadosPagamento, decimal valorCompra)
        {

            if (string.IsNullOrEmpty(dadosPagamento.NumeroCartao))
                return false;

            if (string.IsNullOrEmpty(dadosPagamento.CodigoSeguranca))
                return false;

            if (string.IsNullOrEmpty(dadosPagamento.NomeCartao))
                return false;

            //A Maioria das pessoas continua a adicionar IFs no código, 
            //tornando o método cada vez mais complexo e dificil de manter

            if (!SERASA.ClienteTemNomeSujo(cliente.Nome))
                return false;

            if (valorCompra > 1000) {
                //Faz processamento manual da operação para verificar possíveis fraudes.
            }
                
            //Com o passar do tempo e o aumento do número de regras esse método vira uma BOMBA relógio!!!

            return true;
        }
    }
}
