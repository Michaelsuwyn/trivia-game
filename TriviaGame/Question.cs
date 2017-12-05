using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
     class Question
    {
        public string Phrase { get; set; }
        public string Answer { get; set; }



       public static Question deal(List<Question> list)
        {
            shuffle(list);
            Question Numone = list[0];
            list.RemoveAt(0);
            return Numone;
        }
         
        public static void shuffle(List<Question> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while(n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                Question value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

        }
    }
}

