using Exercicios_Ada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01
{
    // Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
    internal class Varejo : Empresa 
    {
        public override void RealizarVenda()
        {
            Console.WriteLine("Parabéns! Você vendeu um produto");
        }

    }
}
