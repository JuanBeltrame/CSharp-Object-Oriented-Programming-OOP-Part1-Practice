namespace _02._1._02_Library
{
    public class Validador
    {
        public static bool ValidarRespuesta(char value) => value switch
        {
            's' => true,
            'n' => false,
            _ => false
        };
    }
}
