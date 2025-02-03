// See https://aka.ms/new-console-template for more information
using _02._1._03_Library;

Console.Title = "Ejercicio I03 - Conversor binario - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

int number = int.Parse(Console.ReadLine()!);
Conversor.ConvertirDecimalABinario(number);