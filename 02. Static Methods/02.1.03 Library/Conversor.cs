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

        public static int BinaryToDecimal(string valorRecibido)
        {
            int resultado = 0; // Valor a retornar; lo inicializamos en cero dado que si la cadena recibida no corresponde a un binario, retornamos cero
            int cantidadCaracteres = valorRecibido.Length; // Guardamos la longitud de la cadena para saber hasta donde tenemos que ir calculando. 
            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
            }
            return resultado;
        }
    }
}
