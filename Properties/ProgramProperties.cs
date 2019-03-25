using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class ProgramProperties
    {
        class Player
        {
            private  int _health = 100;//the field for the players health
            public int health //property for players health
            {
                get
                {
                    return _health;
                }
                set
                {
                    if (value <= 0)
                    {
                        _health = 0;
                    }
                    else if (value >= 100)
                    {
                        _health = 100;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            }          
        }
        static void Main(string[] args)
        {
            Player donnyves = new Player();
            Console.WriteLine(donnyves .health );
            donnyves.health -= 200;
            Console.WriteLine(donnyves.health);
            donnyves.health += 400;
            Console.WriteLine(donnyves.health);
            donnyves.health = 70;
            Console.WriteLine(donnyves.health);
            donnyves.health += 10;
            Console.WriteLine(donnyves.health);

            Console.ReadKey();
        }
    }
}
