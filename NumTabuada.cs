using System.Net.NetworkInformation;

namespace Exercicios;

class NumTabuada
{
  public static void Multiplicar()
  {
    Console.WriteLine("Digite um número para mostrar toda a tabuada até o 10");
    int i = Convert.ToInt32(Console.ReadLine());
    int j = 0;
    while ( j <= 10)
    {
      Console.WriteLine("Número " + i + " multiplicado pelo número " + j + " É igual a: " + i*j);
      j++;
    }
  }
}