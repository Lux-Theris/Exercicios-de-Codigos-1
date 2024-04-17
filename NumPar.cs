using System.Net.NetworkInformation;

namespace Exercicios;

class NumPar
{
  public static void Paridade()
  {
    Console.WriteLine("Todos os números pares entre o número 1 ao número 20");
    for (int i = 0; i <= 20; i++)
    {
      if (i % 2 == 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}