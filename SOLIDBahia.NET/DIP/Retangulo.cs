using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.DIP
{
    public class Retangulo
    {

        public int Largura { get; set; }
        public string Cor { get; set; }
        public int Altura { get; set; }


        public void Pintar()
        {
            if (string.IsNullOrEmpty(Cor))
                throw new Exception("Você não escolheu a cor");

            Console.WriteLine("Pintando rentangulo de: "+Cor);
            //Logia de pintar retangulo
        }

    }
}
