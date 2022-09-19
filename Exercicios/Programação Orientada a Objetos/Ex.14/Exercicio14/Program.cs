using Exercicio14;
using System;
using System.Globalization;

Aluno a = new Aluno();
for (int i = 0; i <= 2; i++)
{
    Console.Write($"Informe a nota do {i + 1}º do aluno: ");
    a.Notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
Console.WriteLine("Nota total = " + a, CultureInfo.InvariantCulture);
if (a.Aprovado())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("Faltaram "  + a.ValorRestante().ToString("F2",CultureInfo.InvariantCulture) + " pontos");
}
