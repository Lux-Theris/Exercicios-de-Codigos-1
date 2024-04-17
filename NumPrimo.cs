using System.Net.NetworkInformation;

namespace Exercicios;

class NumPrimo
{
  public static void Primar()
  {
    Console.WriteLine("Digite o Número para ver se é primo");
    int i = Convert.ToInt32(Console.ReadLine());
    int j = 1;
    int Counter = 0;
    while (j <= i)
    {
      if (i % j == 0)
      {
        Counter++;
      }
      j++;
    }
    if (Counter == 2 || Counter == 1)
    {
      Console.WriteLine("O número " + i + " é um número primo");
    } else
    {
      Console.WriteLine("O número " + i + " não é primo");
    }
  }
}