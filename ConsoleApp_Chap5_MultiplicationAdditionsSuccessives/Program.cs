namespace ConsoleApp_Chap5_MultiplicationAdditionsSuccessives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre :");
            int nombre = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplier par :");
            int multiplier = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int resultat = 0;
            while (multiplier > 0)
            {
                resultat = resultat + nombre;
                Console.WriteLine(resultat);
                multiplier--;
            }
        }
    }
}