// See https://aka.ms/new-console-template for more information
using Calculadora.Services;

CalculadoraServico calc = new CalculadoraServico();

calc.Somar(10, 5);
calc.Somar(85, 6);
calc.Somar(0, 9);
calc.Somar(72, 3);


foreach (string item in calc.RetornaHistorico())
{
    Console.WriteLine(item);
}
