using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleInheritance
{
    public class Player : Character, IBattle
    {
        public int Lives { get; set; }
        public int ExperiencePoints { get; set; }

        public Player()
        {

        }

        public Player(int id, string name, bool isActive, int lives, int experiencePoints)
            : base(id, name, isActive)
        {
            Lives = lives;
            ExperiencePoints = experiencePoints;
        }

        public override  string Greeting()
        {
            return "Robin is a meanie!";
        }


        public int Attack(int experiencePoints)
        {
            throw new NotImplementedException();
        }

        public int Defend(int experiencePoints)
        {
            throw new NotImplementedException();
        }
    }
}
