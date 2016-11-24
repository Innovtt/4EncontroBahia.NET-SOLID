using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET
{
    public class FakeDb
    {
        public bool Insert(object entidade)
        {
            Console.WriteLine("SAVING...");
            Console.WriteLine("Salvou: " + entidade.ToString());
            Console.WriteLine("#####");
            return true;
        }

        internal bool ExistePessoa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
