using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public FootballPlayer(string name, int number, int age, double height): base(name, age)
        {
            this.Number = number;
            this.Height = height;
        }
    }
}
