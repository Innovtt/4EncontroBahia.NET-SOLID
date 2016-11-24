using SOLIDBahia.NET.DIP;
using SOLIDBahia.NET.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSRPWrong();


            Console.WriteLine("FIM");
            Console.ReadLine();
        }

        public static void RunDIP() {
            //A maioria das pessoas faz assim:
            var ret = new Retangulo()
            {
                Altura = 10,
                Largura = 5
            };

            //Vai dar merda! 
            //Porque o "chamador" da classe não sabia que deveria preencher a propriedade COR
            //Se o valor é importante para o objeto, devemos forçar no construtor 
            //e se é importante para o método, devemos forçar na assinatura do método.
            //Não podemos confirar que o chamador vai preencher a propriedade 
            ret.Pintar();
        }

        public static void RunSRPWrong() {

            //Já não estamos violando um principio aqui?
            var cliente = new Pessoa() { Id = 1, Nome = "João", Email = "joao@innovt.com.br" };
            var servicoDeReserva = new ReservaOnline();
            servicoDeReserva.Reserva(326,cliente);

        }
    }
}
