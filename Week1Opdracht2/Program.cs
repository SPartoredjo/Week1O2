using System;
using System.Collections.Generic;
using System.Linq;

namespace Week1Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Question> question = new List<Question>();

            Question first = new Question()
            {
                difficulty = 1,
                category = "Java Knowledge",
                text = "What was the name of the inventor of Java",
                answer = "James Gosling"
            };

            Question second = new Question()
            {
                difficulty = 2,
                category = "Car Knowledge",
                text = "What is the name of the new BMW 6-Serie model",
                answer = "BMW 6-Serie GT"
            };

            Question third = new Question()
            {
                difficulty = 3,
                category = "World knowledge",
                text = "What is the name of the president of South Korea",
                answer = "Moon Jae-in"
            };

            ChoiceQuestion fourth = new ChoiceQuestion()
            {
                difficulty = 1,
                category = "Java Knowledge",
                text = ("In which country was the inventor of Java born"),

            };

            fourth.AddChoice("Australia", false);
            fourth.AddChoice("Denmark", false);
            fourth.AddChoice("Canada", true);
            fourth.AddChoice("United States", false);

            ChoiceQuestion fifth = new ChoiceQuestion()
            {
                difficulty = 3,
                category = "World Knowledge",
                text = "Who was the president of the United States during the Civil War"
            };

            Question sixth = new Question()
            {
                difficulty = 2,
                category = "World Knowledge",
                text = "What year did Donald Trump become the president of the USA",
                answer = "2017"
            };

            fifth.AddChoice("Abraham Lincoln", true);
            fifth.AddChoice("Donald Trump", false);
            fifth.AddChoice("Barack Obama", false);
            fifth.AddChoice("Franklin Roosevelt", false);

            question.Add(first);
            question.Add(fifth);
            question.Add(third);
            question.Add(second);
            question.Add(fourth);
            question.Add(sixth);

            SortDifficulty(question);
            Console.WriteLine("");
            SelectDifficulty(question);

            Console.ReadKey();
        }

        public static void SortDifficulty(List<Question> question)
        {
            var tmp = from d in question
                      orderby d.difficulty
                      select d;

            foreach (Question d in tmp)
            {
                Console.WriteLine("Difficulty: " + d.difficulty + " " + d.text);
            }
        }

        public static void SelectDifficulty(List<Question> question)
        {
            Console.WriteLine("Select difficulty: 1/2/3");

            int diff = Convert.ToInt32(Console.ReadLine());

            question = (from x in question
                        where x.difficulty == diff
                        select x).ToList();

            foreach (Question x in question)
            {
                Console.WriteLine("");
                PresentQuestion(x);
            }
        }

        public static void PresentQuestion(Question Q)
        {
            Q.Display();
            Console.WriteLine("Your answer: ");
            string answer = Console.ReadLine();
            string response = answer;
            Console.WriteLine(Q.CheckAnswer(response));
            Console.WriteLine("");
        }
    }
}
