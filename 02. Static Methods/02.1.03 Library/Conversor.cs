using System.Security.Cryptography.X509Certificates;

namespace _02._1._03_Library
/* 
Excercise Link: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/estaticos/Ejercicios/I03-conversor-binario/
*/
{
    public sealed class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string? binaryValue = default;
            int resto;

            do
            {
                numeroEntero /= 2;
                resto = numeroEntero % 2;
                binaryValue = binaryValue + resto.ToString();
            } while (resto != 0);
            return binaryValue;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            return
        }
    }
}
