using System.Net.NetworkInformation;

namespace Exercicios;

class SomaCem
{
  public static void Somar()
  {
    Console.WriteLine("Somando até o número 100... ");
    int i=0;
    int j=0;
    while(j<101)
    {
      i=i+j;
      j++;
    }
    Console.WriteLine("A soma total é de: " + i);
  }
}