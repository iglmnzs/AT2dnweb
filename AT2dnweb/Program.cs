namespace AT2dnweb
{
    internal class Program
    {
        delegate void Deleg(string frase);
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a frase a ser convertida:");
            string fraseDigitada = Console.ReadLine();

            Deleg fraseMaiuscula = delegate (string frase)
            {
                Console.WriteLine("Conversão para maiúsculo: " + frase.ToUpper());
            };

            Deleg fraseMinuscula = delegate (string frase)
            {
                Console.WriteLine("Conversão para minúsculo: " + frase.ToLower());
            };

            fraseMaiuscula(fraseDigitada);
            fraseMinuscula(fraseDigitada);
        }
    }
}
