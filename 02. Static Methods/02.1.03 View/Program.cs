using _02._1._03_Library;

Console.Title = "Ejercicio I03 - Conversor binario - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

List<int> binaryNumbers = new();

int number = int.Parse(Console.ReadLine()!);
string binaryNumber = Conversor.ConvertirDecimalABinario(number);
foreach (var item in binaryNumbers)



    Console.WriteLine(binaryNumber);