using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Ada
{

    //Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
    public abstract class Empresa
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        public string CNPJ { get; set; }

        public DateOnly DataAbertura { get; set; }

        public string TelefoneContato { get; set; }

        // Construa um método para imprimir as informações da empresa.
        public void ImprimirDados()
        {
            Console.WriteLine("Razão Social:" + RazaoSocial);
            Console.WriteLine("Nome Fantasia:" + NomeFantasia);
            Console.WriteLine("CNPJ:" + CNPJ);
            Console.WriteLine("Data de Abertura:" + DataAbertura);
            Console.WriteLine("Telefone de Contato:" + TelefoneContato);
        }

        //Construa um método abstrato void RealizarVenda()
        public abstract void RealizarVenda();
        

    }


}

   
