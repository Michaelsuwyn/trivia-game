using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class Team
    {
        public int Points { get; set; }
        public string Name { get; set; }



        public static void addPoints(Team team)
        {
            team.Points += 1;
        }
    }


    
}
