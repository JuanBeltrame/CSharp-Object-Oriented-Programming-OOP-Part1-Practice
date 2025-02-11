using _02._1._03_Library;

Console.Title = "Ejercicio I03 - Conversor binario - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;


Console.Write("Ingresar un numero: ");
Console.WriteLine();
if (!int.TryParse(Console.ReadLine()!, out int number))
    Console.WriteLine("Se debe ingresar un numero");

string binaryNumber = Conversor.ConvertirDecimalABinario(number);
Console.Write($"Su valor en Binario es: {binaryNumber}");






