using System.Net.NetworkInformation;

namespace Exercicios;

class CalcFatorial
{
  public static void Fatorar()
  {
    Console.WriteLine("Digite o número para fatorar:");
    int i = Convert.ToInt32(Console.ReadLine());
    for (int j = i - 1; j >= 1; j--)
    {
      i = i * j;
    }
    Console.WriteLine("O fatorial é " + i);
  }
}