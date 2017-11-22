using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opdracht2Week1deel2
{
   public class ChoiceQuestion : Question
    {

        public List<String> choices;

        public ChoiceQuestion()
        {
            choices = new List<string>();
        }

        public void AddChoices(String choice, Boolean correct)
        {
            choices.Add(choice);
            if (correct)
            {
                String choiceString = "" + choices.Count;
                SetAnswer(choiceString);
            }
        }

        public override void Display()
        {
            base.Display();

            for (int i = 0; i < choices.Count; i++)
            {
                int choicenumber = i + 1;
                Console.WriteLine(choicenumber + ": " + choices.ElementAt(i));


            }
        }
    }
}
