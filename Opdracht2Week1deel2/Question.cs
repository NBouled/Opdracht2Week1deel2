using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2Week1deel2
{
   public class Question
    {

        public String Text { get; set; }
        public String Answer { get; set; }
        public int Lvl { get; set; }
        public String Categorie { get; set; }

        public Question()
        {
            Text = "";
            Answer = "";
            
        }

        public void SetQuestion(String text)
        {
            this.Text = text;

        }

        public void SetAnswer(String answer)
        {
            this.Answer = answer;
        }

        public Boolean CheckAnswer(String response)
        {
            return response.Equals(Answer);

        }

        public virtual void Display()
        {
            Console.WriteLine(Text);
        }


    }
}
