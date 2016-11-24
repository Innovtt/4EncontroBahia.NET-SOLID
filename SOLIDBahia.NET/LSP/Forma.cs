using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.LSP
{
    public abstract class Forma
    {
        public abstract double CalculaArea();
    }

    public class Retangulo : Forma
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public override double CalculaArea()
        {
            return Largura * Altura;
        }
    }

    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public override double CalculaArea()
        {
            return Raio * Raio * Math.PI;
        }
    }

    public class CalculadoraArea
    {
        public double Area(Forma[] formasGeometricas)
        {
            double area = 0;
            foreach (var forma in formasGeometricas)
            {

                forma.CalculaArea();
            }

            return area;
        }
    }
}
