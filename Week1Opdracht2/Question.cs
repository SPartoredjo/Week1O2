using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Opdracht2
{
    class Question
    {

        public int difficulty { get; set; }
        public string category { get; set; }
        public string text { get; set; }
        public string answer { get; set; }

        public Question()
        {
            text = "";
            answer = "";
        }

        public void SetText(string questiontext)
        {
            text = questiontext;
        }

        public void SetAnswer(string correctresponse)
        {
            answer = correctresponse;
        }

        public bool CheckAnswer(string response)
        {
            return response.Equals(answer);
        }

        public virtual void Display()
        {
            Console.WriteLine(text);
        }
    }
}
