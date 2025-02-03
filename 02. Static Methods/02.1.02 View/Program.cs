using _02._1._02_Library;
/* 
Excercise Link: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/estaticos/Ejercicios/I02-desea-continuar/
*/

Console.Title = "Ejercicio I02 - ¿Desea continuar? - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;


int acumulator = 0;
int number01;
int number02;
char desicion;

Console.WriteLine($"Ingresar dos numeros entero: ");
number01 = int.Parse(Console.ReadLine()!);
number02 = int.Parse(Console.ReadLine()!);
acumulator += number01;
acumulator += number02;
Console.Write($"El Total es: {acumulator}");
Console.WriteLine();

Console.WriteLine("Desea Continuar? (S/N): ");
desicion = char.Parse(Console.ReadLine()!);
Validador.ValidarRespuesta(desicion);

while (Validador.ValidarRespuesta(desicion))
{
    acumulator = 0;
    Console.WriteLine($"Ingresar dos numeros entero: ");
    number01 = int.Parse(Console.ReadLine()!);
    number02 = int.Parse(Console.ReadLine()!);
    acumulator += number01;
    acumulator += number02;
    Console.Write($"El Total es: {acumulator}");
    Console.WriteLine();

    Console.WriteLine("Desea Continuar? (S/N): ");
    desicion = char.Parse(Console.ReadLine()!);
    Validador.ValidarRespuesta(desicion);
}

