using System;

    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello Develop03 World!");
            // The scripture
            Scripture scripture = new Scripture("Isaiah ", 43, 2, "When thou passest through the awaters, I will be with thee; and through the rivers, they shall not overflow thee: when thou walkest through the bfire, thou shalt not be cburned; neither shall the flame kindle upon thee.");
            // Clear the Console.
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'q' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'q' to exit.");
            }
        }
    }
