using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public decimal ValorNaConta { get; set; }
        public object DataNascimento { get; internal set; }

        public bool ClienteTemCredito()
        {
            return false;
        }
    }
}
