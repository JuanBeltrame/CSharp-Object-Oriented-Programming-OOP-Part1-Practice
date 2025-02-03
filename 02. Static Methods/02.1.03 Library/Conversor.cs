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
            List<int> binaryNumber = new();
            foreach (int number in binaryNumber)
            {
                do
                {
                    int residuo = numeroEntero % 2;
                    numeroEntero /= 2;

                    binaryNumber.Add(residuo);
                } while (numeroEntero != 0);

                return binaryNumber.ToString()!;
            }
        }

        //public static int ConvertirBinarioADecimal(int numeroEntero)
        //{
        //    return
        //}
    }
}
