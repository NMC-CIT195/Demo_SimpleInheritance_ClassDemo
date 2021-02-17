using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleInheritance
{
    class Program
    {
        static Player _player;
        static List<Npc> _monsters;
        static Npc _myMonster;

        static void Main(string[] args)
        {
            InitializeGame();

            foreach (Npc monster in _monsters)
            {
                Console.WriteLine(monster.Greeting());
            }

            Console.WriteLine(_player.Greeting());

            // LINQ
            //_myMonster = _monsters.FirstOrDefault(m => m.Id == 4);



            Console.ReadKey();
        }

        static private void InitializeGame()
        {
            _player = new Player(1, "Bonzo", true, 3, 100);

            _monsters = new List<Npc>()
            {
                new Npc()
                {
                    Id = 2,
                    Name = "Fred",
                    CanBattle = true,
                    IsActive = false
                },

                new Npc()
                {
                    Id = 3,
                    Name = "Bill",
                    CanBattle = true,
                    IsActive = false
                },

                new Npc(4, "Suzy", true, true)
            };
        }
    }
}
