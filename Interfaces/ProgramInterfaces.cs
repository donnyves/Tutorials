using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ProgramInterfaces
    {
        interface IItem
        {
            string name { get; set; }
            int goldValue { get; set; }

            void Equip();
            void Sell();
        }
        interface IDamagable
        {
            int durability { get; set; }

            void TakeDamage(int _amount);        
        }
        interface IPartOfQuest
        {
            void TurnIn();
        }
        //Implement the Interface with the class using : to inherit and use a , for addition interface tags
        class Sword : IItem , IDamagable , IPartOfQuest 
        {
            public string name { get; set; }
            public int goldValue { get; set; }

            
            public int durability { get; set; }
            public Sword (string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 30;
            }
            public void Equip()
            {
                Console.WriteLine($"{name} has not been equipped.");
            }
            public void Sell()
            {
                Console.WriteLine($"{name} sold for ${goldValue} imaginary dollars");
            }
            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine($"{name} damaged by {_dmg }. It now has a durability of {durability} ");
            }

            public void TurnIn()
            {
                Console.WriteLine($"{name} turned in");
            }
        }
        class Axe : IItem, IDamagable
        {
            public string name { get; set; }
            public int goldValue { get; set; }


            public int durability { get; set; }
            public Axe(string _name)
            {
                name = _name;
                goldValue = 70;
                durability = 50;
            }
            public void Equip()
            {
                Console.WriteLine($"{name} has not been equipped.");
            }
            public void Sell()
            {
                Console.WriteLine($"{name} sold for ${goldValue} imaginary dollars");
            }
            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine($"{name} damaged by {_dmg }. It now has a durability of {durability} ");
            }
        }


        static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.TakeDamage(20);
            sword.Sell();
            sword.TurnIn();
            Console.WriteLine();
            Axe axe = new Axe("Axe of fury");
            axe.Equip();
            axe.TakeDamage(10);
            axe.Sell();

            //Create an Inventory
            IItem[] inventory = new IItem[2];
            inventory[0] = sword;
            inventory[1] = axe;
            Console.WriteLine();

            //Loop through and turn in all quest items
            //You have to case IPartOfQuest using the "as" keyword

            for (int i = 0; i < inventory .Length; i++)
            {
                IPartOfQuest questItem = inventory[i] as IPartOfQuest;

                if (questItem != null)
                {
                    questItem.TurnIn();
                }
            }

            Console.ReadKey();
        }
    }
}
