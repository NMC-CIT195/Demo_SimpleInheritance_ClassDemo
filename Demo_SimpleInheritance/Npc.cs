using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleInheritance
{
    public class Npc : Character
    {
        public bool CanBattle { get; set; }

        public Npc()
        {

        }

        public Npc(int id, string name, bool isActive, bool canBattle)
            : base(id, name, isActive)
        {
            CanBattle = canBattle;
        }

        public override string Greeting()
        {
            return "Robin is a meanie!";
        }
    }
}
