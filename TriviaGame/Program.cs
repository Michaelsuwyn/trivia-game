using System;
using System.Collections.Generic;

namespace TriviaGame
{
    class Program
    {
      

        static void Main(string[] args)
        {
            bool isGameOver = new bool();
           
            //Questions for trivia hard coded in
            Question one = new Question();
            one.Phrase = "What Hawaiin princess leaves her island to save her people?";
            one.Answer = "moana";

            Question two = new Question();
            two.Phrase = "what does Aladdin disguise himself to be, in order to win over princess Jasmine? ";
            two.Answer = "prince";

            Question three = new Question();
            three.Phrase = "What Disney character is known for the line... Long live the king";
            three.Answer = "scar";

            Question four = new Question();
            four.Phrase = "What is princesss Jasmines pet tigers name?";
            four.Answer = "rajah";

            Question five = new Question();
            five.Phrase = "In toy story what game does the slinky play?";
            five.Answer = "checkers";

            Question six = new Question();
            six.Phrase = "In Hercules, How many hours must Hercules give up his strength when he makes a deal with Hades, in order to keep Megera safe?";
            six.Answer = "24";

            Question seven = new Question();
            seven.Phrase = "What was the name of the whale in Pinocchio?";
            seven.Answer = "monstro";

            Question eight = new Question();
            eight.Phrase = "In Bambi, what word does the owl use to describe falling in love?";
            eight.Answer = "twitterpatted";

            Question nine = new Question();
            nine.Phrase = " In the Lion King, where does Mufasa and his family live?";
            nine.Answer = "pride rock";

            Question ten = new Question();
            ten.Phrase = "In Beauty and the Beast, how many dozens of eggs does Gaston eat for breakfast?";
            ten.Answer = "5";

            Question eleven = new Question();
            eleven.Phrase = "What is the name of Donald Duck’s sister (Also the mother of Huey Dewey & Louie) ?";
            eleven.Answer = "dumbella";

            Question twelve = new Question();
            twelve.Phrase = "During the ballroom scene of Beauty & the Beast, what color is Belle’s Gown? ";
            twelve.Answer = "gold";

            Question thirteen = new Question();
            thirteen.Phrase = "Which is the only Disney animated film with a main character that doesn’t speak?";
            thirteen.Answer = "dumbo";

            Question fourteen = new Question();
            fourteen.Phrase = "Which character's voice is played by Eddie Murphy in Mulan?";
            fourteen.Answer = "mushu";

            Question fifteen = new Question();
            fifteen.Phrase = "How many years has the curse been over the castle in Beauty and the Beast?";
            fifteen.Answer = "10";





            List<Question> Questions =new List<Question>() { one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve,
            thirteen, fourteen, fifteen};
            Question.shuffle(Questions);

            Question mainQ = new Question();
            Question.shuffle(Questions);



            Team teamone = new Team();
            Team teamtwo = new Team();
            teamone.Name = "teamone";
            teamtwo.Name = "teamtwo";





            while (isGameOver == false)
            {
                string reader = "";
                Question.shuffle(Questions);
                
                mainQ = Question.deal(Questions);

                Console.WriteLine("Team 1 is up");

                Console.WriteLine(teamone.Name + ": " + teamone.Points);
                Console.WriteLine(teamtwo.Name + ": " + teamtwo.Points);

                Console.WriteLine(mainQ.Phrase);
                reader = Console.ReadLine().ToLower();
                if (reader == mainQ.Answer)
                {
                    Console.WriteLine("Correct! Team one gets a point! ");
                    Team.addPoints(teamone);
                }
                else
                {
                    Console.WriteLine("Incorrect! Team two what is your answer?");
                    reader = Console.ReadLine().ToLower();
                    if (reader == mainQ.Answer)
                    {
                        Console.WriteLine("Correct! Team two gets a point! ");
                        Team.addPoints(teamtwo);
                    }
                    else
                    {
                        Console.WriteLine("The correct answer is: " + mainQ.Answer);
                    }
                }
                Console.WriteLine(teamone.Name + ": " + teamone.Points);
                Console.WriteLine(teamtwo.Name + ": " + teamtwo.Points);

                Console.ReadLine();

                Question.shuffle(Questions);

                mainQ = Question.deal(Questions);

                Console.WriteLine("Team 2 is up");
                Console.WriteLine(mainQ.Phrase);
                reader = Console.ReadLine().ToLower();
                if (reader == mainQ.Answer)
                {
                    Console.WriteLine("Correct! Team two gets a point! ");
                    Team.addPoints(teamtwo);
                }
                else
                {
                    Console.WriteLine("Incorrect! Team One what is your answer?");
                    reader = Console.ReadLine().ToLower();
                    if (reader == mainQ.Answer)
                    {
                        Console.WriteLine("Correct! Team one gets a point! ");
                        Team.addPoints(teamone);
                    }
                    else
                    {
                        Console.WriteLine("The correct answer is: " + mainQ.Answer);
                    }
                }
                Console.WriteLine(teamone.Name + ": " + teamone.Points);
                Console.WriteLine(teamtwo.Name + ": " + teamtwo.Points);

                Console.ReadLine();
            }


        }
    }
}
 