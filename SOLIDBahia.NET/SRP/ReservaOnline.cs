using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.SRP
{
    public class ReservaOnline
    {
        public void Reserva(int codLugar, Pessoa cliente) {
            
            //Regras de negócio

            new FakeDb().Insert(cliente);

            EnviarEmailSucessoCompra(cliente.Nome, cliente.Email);
        }

        //O que esse método tem a ver com a responsabilidade de reservar?
        public void EnviarEmailSucessoCompra(string nomeCliente, string emailCliente) {

            //Logica para montagem do e-mail 
            Console.WriteLine("Construindo e-mail customizado para: " + nomeCliente);
            //Logica de envio do e-mail
            Console.WriteLine("Email enviado com sucesso para: " + nomeCliente);
            return;
        }

        //O que esse método tem a ver com a responsabilidade de reservar?
        //Esse método é tão generico que poderia estar em dezenas de lugares. 
        //E provavelmente está, porque as pessoas acabam replicando esse tipo de lógica em todo canto 
        public bool ValidaUsuarioTemCadastro(Pessoa usuario) {

            if (usuario == null)
                return false;

            var banco = new FakeDb();

            if (banco.ExistePessoa(usuario.Id))
            {
                return true;
            }

            return false;
        }
    }
}
