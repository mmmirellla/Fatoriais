

using Fatoriais;

Console.WriteLine("Bem vindo ao programa de Fatoração de 1 a 10!");
Console.WriteLine("");
Console.WriteLine("Qual número (de 1 a 10) você quer fatorar?");
int n = Convert.ToInt32(Console.ReadLine());
   
Console.WriteLine($"{n}! = " + CalculoFatorial.Fatorial(n));