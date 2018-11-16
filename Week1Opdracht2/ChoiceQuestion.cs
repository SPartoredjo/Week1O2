using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Opdracht2
{
    class ChoiceQuestion : Question
    {
        private List<string> choices;

        public ChoiceQuestion()
        {
            choices = new List<string>();
        }

        public void AddChoice(string choice, bool correct)
        {
            choices.Add(choice);
            if(correct)
            {
                string ChoiceString = "" + choices.Count;
                SetAnswer(ChoiceString);
            }
        }

        public override void Display()
        {
            base.Display();
            for(int i = 0; i < choices.Count; i++)
            {
                int ChoiceNumber = i + 1;
                Console.WriteLine(ChoiceNumber + ": " + choices[i]);
            }
        }
    }
}
