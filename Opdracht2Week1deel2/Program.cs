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

            Console.WriteLine("Welkom. ")

        }
    }

}
