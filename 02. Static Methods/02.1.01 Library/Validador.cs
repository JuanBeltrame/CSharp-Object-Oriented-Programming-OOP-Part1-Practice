namespace _02._1._01_Library
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max) => (valor <= min) || (max <= valor) ? false : true;
           
    }
}