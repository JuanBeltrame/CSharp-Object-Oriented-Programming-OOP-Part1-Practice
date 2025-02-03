/* 
Excercise Link: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/estaticos/Ejercicios/I01-validador-rangos/
*/

//--Programa Principal---

using _02._1._01_Library;

Console.Title = "Ejercicio I01 - Validador de rangos - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

Random rn = new();
int capacity = 10;
int maxValue = -100;
int minValue = 100;
int counter = default;
int acumulator = default;
int average = default;

for (int i = 0; i < capacity; i++)
{
    int randomValue = rn.Next(-300, 301);
    if (Validador.Validar(randomValue, -100, 100))
    {
        counter += 1;
        acumulator += randomValue;
        Console.WriteLine($"{randomValue} Esta dentro del rango");

        if (randomValue > maxValue)
            maxValue = randomValue;
        else if (randomValue < minValue)
            minValue = randomValue;
    }
    else
        Console.WriteLine($"{randomValue} Numero fuera de rango");
}

Console.WriteLine($"El valor mas maximo ingresado fue el: {maxValue}");
Console.WriteLine($"El valor mas minimo ingresado fue el: {minValue}");
Console.WriteLine($"El promedio es: {average = acumulator/counter}");
