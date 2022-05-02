using System;
using System.IO;
using System.Text;

namespace CalculaNota
{
    class Test
    {
        // Main  
        static void Main(string[] args)
        {
            string nome;
            float nota1;
            float nota2;
            float nota3;
            float notafinal;


            //ler o nome do aluno e a nota dos 3 testes
            Console.Write("Introduza o seu nome : ");
            Console.Write("Introduza a nota do primeiro teste: ");
            Console.Write("Introduza a nota do segundo teste: ");
            Console.Write("Introduza a nota do terceiro teste: ");

            //calcula a classificação final
            notafinal = nota1 * 0.2 + nota2 * 0.5 + nota3 * 0.3;

            //determina a situação do aluno
            if notafinal >= 10 
                aluno aprovado
                    else 
                aluno reprovado
                

            //imprime nome, classificação final e situação do aluno
            Console.WriteLine();
            

            //exit
            Console.ReadLine();
        }
    }
}
