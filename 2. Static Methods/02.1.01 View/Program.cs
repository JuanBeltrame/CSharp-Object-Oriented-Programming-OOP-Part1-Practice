/* 
Excercise Link: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/estaticos/Ejercicios/I01-validador-rangos/
*/

//--Programa Principal---

using _02._1._01_Library;

Random rn = new();
int capacity = 10;

for (int i = 0; i < capacity; i++)
{
    int randomValue = rn.Next(-300,301);
    if (Validador.Validar(randomValue, -100, 100))
    {
        System.Console.WriteLine($"{randomValue} Esta dentro del rango");      
    }
    else
    {
        System.Console.WriteLine($"{randomValue} Numero fuera de rango");
    }
}
