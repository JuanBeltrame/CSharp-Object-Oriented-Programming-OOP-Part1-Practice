using _02._1._02_Library;
/* 
Excercise Link: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/estaticos/Ejercicios/I02-desea-continuar/
*/

int acumulator = 0;
int number;
char desicion;

Console.Write($"Ingresar un numero entero: ");
number = int.Parse(Console.ReadLine()!);
acumulator += number;

Console.WriteLine("Desea Continuar? (S/N): ");
desicion = char.Parse(Console.ReadLine()!);

while (Validador.ValidarRespuesta(desicion))
{
    Console.Write($"Ingresar un numero entero: ");
    number = int.Parse(Console.ReadLine()!);
    acumulator += number;

    desicion = char.Parse(Console.ReadLine()!);
    Console.WriteLine("Desea Continuar? (S/N): " );
}