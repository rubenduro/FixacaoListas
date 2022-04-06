using System;
using System.Globalization;
using System.Collections.Generic;

namespace FixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Introduza o número de funciopnários que vai introduzir:");
            N = int.Parse(Console.ReadLine());

            List<Funcionarios> lista = new List<Funcionarios>();

            for(int i = 1; i < N + 1; i++)
            {
                Console.WriteLine("Dados do " + i + " funcionario: ");
                Console.Write("ID: ");
                string cpf = Console.ReadLine();

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Funcionarios f = new Funcionarios(cpf, name, salario);
                lista.Add(f);
            }

            Console.WriteLine();
            Console.Write("Introduza o CPF do funcionário que vai ter aumento: ");
            string cpfIntroduzido = Console.ReadLine();

            int pos = lista.FindIndex(x => x.Cpf == cpfIntroduzido);

            if(pos == -1)
            {
                Console.WriteLine("CPF inexistente!!!");
            }
            else
            {
                Console.Write("Digite a percentagem de aumento: ");
                double per = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   
                lista[pos].aumentarSalario(per);
            }

            Console.WriteLine();
            Console.WriteLine("Listagem atualizado dos funcionarios: ");
            for(int i = 0; i < N + 1; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();
        }
    }
}
