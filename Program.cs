using System;
using System.Collections.Generic;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> alunos = new List<dynamic>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo ao sistem de genreciamento de notas!!");
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1 - Cadastrar aluno e notas");
                Console.WriteLine("2 - Exibir relatório");
                Console.WriteLine("0 - Finalizar");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite seu nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite a primeira nota: ");
                    float nota1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda nota: ");
                    float nota2 = float.Parse(Console.ReadLine());

                    var aluno = new
                    {
                        nome,
                        nota1,
                        nota2
                    };

                    alunos.Add(aluno);
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    foreach (var aluno in alunos)
                    {
                        float media = (aluno.nota1 + aluno.nota2) / 2;
                        Console.WriteLine($"Nome: {aluno.nome} - Média: {Math.Round(media, 2)}");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
