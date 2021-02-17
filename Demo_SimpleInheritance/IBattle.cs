using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleInheritance
{
    public interface IBattle
    {
        int Attack(int experiencePoints);
        int Defend(int experiencePoints);
    }
}
