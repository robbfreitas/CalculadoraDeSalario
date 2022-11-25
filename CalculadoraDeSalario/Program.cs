using System.Globalization;

namespace CalculadoraDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo(a) ao sistema de cálculo de salário!");

            Console.WriteLine("Informe número de funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe horas trabalhadas: ");
            double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor da hora trabalhada: ");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double calculoSalario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Número do Funcionário e Salário: ");
            Console.WriteLine(numeroFuncionario);
            Console.WriteLine(calculoSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}