using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht2Week1deel2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Question> Quiz = new List<Question> {

            new Question { Text = "Wat is de Hoofdstad van Nederland", Answer = "Amsterdam", Lvl = 1, Categorie = "Topografie" },
            new Question { Text = "Wat is de Hoofdstad van Frankrijk", Answer = "Parijs", Lvl = 1, Categorie = "Topografie" },
            new Question { Text = "Wat is de Hoofdstad van Belgie", Answer = "Brussel", Lvl = 1, Categorie = "Topografie" },

            new ChoiceQuestion { Text = "Wie is de Profeet die de opdracht heeft gekregen om zijn zoon te slachten ? ", Answer = "Ibrahim", choices = new List<string> { "Ibrahim ", "Musa", "Nuh", "Iesah" }, Lvl = 2, Categorie = "Islam" },

            };

            var OrderendQ = Quiz.OrderBy(a => a.Lvl);
            int LvlG = 0;
            String categorie = "";

            Console.WriteLine("Welkom bij de QuizApp! ");
            Console.WriteLine("Kies uit Lvl (Type L)" + "of \n" + "Kies uit Catergorie (Type  C)");
            string keuze = Console.ReadLine();
            if (keuze.Equals("L"))
            {
                Console.WriteLine("Kies Lvl (1, 2, 3)");
                string LvlGraadString = Console.ReadLine();
                Int32.TryParse(LvlGraadString, out LvlG);
            }
            else if (keuze.Equals("C"))
            {
                Console.WriteLine("Kies Catergorie(Topografie, Islam)");
                categorie = Console.ReadLine();
            }

            int count = 0;

            OrderendQ.Where(x => x.Lvl == LvlG || x.Categorie.Equals(categorie)).ToList().ForEach(x =>
            {
                count++;
                Console.Write("vraag " + count + ": ");
                x.Display();
                Console.Write("Uw antwoord: ");
                string antw = Console.ReadLine();
                Console.WriteLine(x.CheckAnswer(antw));
            }

           );
            Console.WriteLine("Einde");
            Console.ReadKey();

        }
    }

}
