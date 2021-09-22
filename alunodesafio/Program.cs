using System;

namespace alunodesafio
{
    class Program
    {
        static void Main(string[] args)
        {

            float nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            media = nota1 + nota2 / 2;
            //se a nota for maior ou igua a 6 cai na condição aluno aprovado, no codigo e feita uma verificação simples "Se" a media e igual a 6(verdadeira) esse codigo e execultado;
            if (media >= 6)
            {
                Console.WriteLine("Aluno aprovado");
            }
            //senão, a nota for menor que 6 ou igual a 5 ele cai na condição de aluno de recuperação
            else if (media < 6 && media >= 4)
            {
                Console.WriteLine("Aluno de recuperação final");
            }

            else
            {
                Console.WriteLine("Aluno reprovado");
            }


        }
    }
}
