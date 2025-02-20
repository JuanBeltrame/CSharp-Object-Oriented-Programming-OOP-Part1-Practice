using System.Numerics;

namespace _02104Library
/* 
Excercise Link: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/estaticos/Ejercicios/I04-la-calculadora/
*/
{
    public class Calculadora
    {
        public static void Calcular(int operando1, int operando2, char operacion)
        {
            int resultado = operacion switch // switch expression
            {
                '+' => operando1 + operando2,
                '-' => operando1 - operando2,
                '*' => operando1 * operando2,
                '/' => CalcularDivision(operando1, operando2)
            };

        }

        private static bool Validar(int operando2) => operando2 is not 0; // expression bodied methods


        private static int CalcularDivision(int operando1, int operando2)
        {
            if (Validar(operando2))
                return operando1 / operando2;
            else
                return -1;
        }
    }
}
