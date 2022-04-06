using System;
using System.Globalization;

namespace FixacaoListas
{
    internal class Funcionarios
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Funcionarios()
        {
        }
        public Funcionarios(string id, string name, double salario)
        {
            Cpf = id;
            Name = name;
            Salario = salario;
        }

        public void aumentarSalario(double percentagem)
        {
            Salario = percentagem * Salario / 100.0 + Salario;
        }

        public override string ToString()
        {
            return Cpf
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
