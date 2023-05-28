using Football;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; }
        //public List<FootballPlayer> players { get; set{} }

        private List<FootballPlayer> players;

        public List<FootballPlayer> Players
        {
            get { return players; }
            set 
            {
                if (value.Count >= 22 || value.Count <= 10)
                {
                    throw new InvalidOperationException("The players need to be from 11 up to 22.");
                }
                players = value; 
            }
        }



        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        // Method to calculate the average age of the players in the team
        public double CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Count;
        }
    }
}
