using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao_dotnet.Models
{
    public class Pessoa 
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine($" Eu sou o {Nome} e tenho {Idade} anoss");
        }

    }
}