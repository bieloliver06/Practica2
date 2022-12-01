namespace Practica2
{
    class Program
    {
        static void Main()
        {
            int nombre = new Random().Next(1, 11);
            int lives = 4;
            while (lives > 0)
            {
                Console.WriteLine("Introdueix un nombre del 1 al 11 : ");
                string? input = Console.ReadLine();
                int guess;
                if (input != null)
                {
                    try
                    {
                        guess = int.Parse(input);
                        if (guess == nombre)
                        {
                            Console.WriteLine("Has guanyat");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No és correcte");
                            --lives;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("No has introduit un nombre!");
                    }
                }
                if (lives == 0) Console.WriteLine("Has perdut");
            }
        }
    }
}