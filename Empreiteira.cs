using Exercicios_Ada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01
{
    // Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.
    internal class Empreiteira : Empresa
    {
        public override void RealizarVenda()
        {
            Console.WriteLine("Parabéns! Você vendeu um serviço");
        }

    }
}
