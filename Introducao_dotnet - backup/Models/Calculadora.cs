using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao_dotnet.Models
{
    public class Calculadora
    {
        
       
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtracao(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            System.Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            System.Console.WriteLine($"{x} ^ {y} = {pot}");
        }

         public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            System.Console.WriteLine($" O Seno de {angulo}º =  {Math.Round(seno, 4) } ");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            System.Console.WriteLine($" O Coseno de {angulo}º =  {Math.Round(coseno, 4)} ");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);

            System.Console.WriteLine($" O Tangente de {angulo}º =  {Math.Round(tangente, 4)} ");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            System.Console.WriteLine($"A raiz quadrada de {x} é = {raiz}");
        }
    }
}