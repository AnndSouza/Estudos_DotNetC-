using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFuncoamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa 
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Apresenta o método da classe Pessoa com "Nome" e "Idade".
        /// </summary>
        public void Apresentar()
        {
            System.Console.WriteLine($" Eu sou o {@Nome} e tenho {Idade} anoss");
        }

    }
}