using System;
using System.Collections.Generic;
namespace Ryggsacken2
{
    class MainClass
    {
        public static void Main(string[] args)
        {   //Skapa ryggsäck i form av en lista
            List<string> ryggan = new List<string>();
            bool isRunning = true;

            while (isRunning)
            
            {
                //Skriv ut menyn
                Console.WriteLine("\tVälkommen till ryggsäcken!");
                Console.WriteLine("\t[1] Lägg till ett föremål");
                Console.WriteLine("\t[2] Skriv ut innehållet");
                Console.WriteLine("\t[3] Radera innehåll");
                Console.WriteLine("\t[4] Avsluta");
                Console.WriteLine("\t Välj:");

                int menyVal = Convert.ToInt32(Console.ReadLine());

                // Använda menyvalet med if

                switch (menyVal)
                {
                    case 1:
                        Console.WriteLine("Vad vill du lägga i ryggsäcken?");
                        string q_newcontent = Console.ReadLine();
                        ryggan.Add(q_newcontent);
                        Console.WriteLine("Tryck på 'Enter' för att återgå");   
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Plockar upp det du har i ryggan");
                        System.Console.WriteLine("Du har totalt " + ryggan.Count + " saker i ryggan");
                        foreach (string thing in ryggan)
                        {
                            System.Console.WriteLine(thing);
                        }
                        Console.WriteLine("Tryck på 'Enter' för att återgå");
                        Console.ReadLine();
                        break; 

                    case 3:
                        Console.WriteLine("Vad vill du radera?");

                        for (int i2 = 0; i2 < ryggan.Count; i2++)
                        {
                            string s = ryggan[i2];
                            Console.WriteLine("[" + i2 + "] " + s);
                        }

                        Console.WriteLine("Ange nr på det du vill radera:");
                        int q_erasestuff = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Du har nu tagit bort: " + ryggan[q_erasestuff]);
                        ryggan.RemoveAt(q_erasestuff);
                        break;

                    case 4:
                        Console.WriteLine("Avslutar programmet");
                        if (menyVal == 4)
                        {
                            //Avsluta programmet
                            isRunning = false;
                        }
                        break;
                }
            } //loop 1

            System.Console.WriteLine();
            Environment.Exit(0);
        }
    }
}
