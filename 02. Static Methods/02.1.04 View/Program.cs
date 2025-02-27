using _02104Library;

Console.Title = "Calculadora";
Console.ForegroundColor = ConsoleColor.Yellow;
char decision = default;


do
{
    Console.Write("Operando 1: ");
    if (!int.TryParse(Console.ReadLine()!, out int value1))
    {
        Console.Write(". Se debe ingresar un valor de tipo numerico");
        return;
    }
    Console.Write("Tipo de Operacion: ");
    if (!char.TryParse(Console.ReadLine()!, out char operation))
    {
        Console.WriteLine("Se debe ingresar un valor de tipo char");
        return;
    }
    Console.Write("Operando 2: ");
    if (!int.TryParse(Console.ReadLine()!, out int value2))
    {
        Console.WriteLine(". Se debe ingresar un valor de tipo numerico");
        return;
    }

    try
    {
        int value = Calculadora.Calcular(value1, value2, operation);
        Console.WriteLine($"Resultado: {value}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    Console.WriteLine(". Desea realizar otra operacion: y/n: ");
    decision = char.Parse(Console.ReadLine()!);
}
while (decision is not 'n');