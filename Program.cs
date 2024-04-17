namespace Exercicios;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
        Exercícios de código
        A seguir estão os exercícios a serem feitos. Digite o número para executar o código do exercício selecionado:]
        1 - Escreva um programa em C# que imprima os números pares de 1 a 20
        2 - Escreva um programa em C# que peça ao usuário um número e imprima a tabuada deste número até 10
        3 - Escreva um programa em c# que calcule a soma dos números de 1 a 100 e imprima o resultado
        4 - Escreva um programa em C# que peça ao usuário um número e imprima se é primo ou não
        5 - Escreva um programa em C# que peça ao usuário um número e calcule o fatorial deste número");
        switch(Console.ReadLine())
        {
            case "1":
                NumPar.Paridade();
                break;
            case "2":
                NumTabuada.Multiplicar();
                break;
            case "3":
                SomaCem.Somar();
                break;
            case "4":
                NumPrimo.Primar();
                break;
            case "5":
                CalcFatorial.Fatorar();
                break;
            default:
                break;
        }
    }
}
