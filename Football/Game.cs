using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Team Team1 { get; }
        public Team Team2 { get; }
        public Referee Referee { get; }
        public List<string> Goals { get; }
        public string Result { get; set; }
        public string Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee)
        {
            if (team1.Players.Count > 11 || team2.Players.Count > 11)
            {
                throw new ArgumentException("Both teams must have only 11 players.");
            }

            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            Goals = new List<string>();
        }

        public void AddGoal(int minute, string player)
        {
            string goal = $"Minute: {minute}, Player: {player}";
            Goals.Add(goal);
        }

        public void SetResult(string result, string winner)
        {
            Result = result;
            Winner = winner;
        }
    }
}
