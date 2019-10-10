using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter FighterA = new Fighter();
            FighterA.name = "Raynor";
            Fighter FighterB = new Fighter();
            FighterB.name = "Tycus";
            


            while (true)
            {
                FighterB.Hurt(FighterA.Attack());

                FighterA.Hurt(FighterB.Attack());

                Console.WriteLine(FighterA.name+" Hp is: " + FighterA.GetHp());
                Console.WriteLine(FighterB.name + " Hp is: " + FighterB.GetHp());

                if (FighterA.IsAlive() == false)
                {
                    Console.WriteLine(FighterB.name +" is our winner!");
                    Console.ReadLine();
                    break;
                }
                else if (FighterB.IsAlive() == false )
                {
                    Console.WriteLine(FighterA.name +" winns this battle!");
                    Console.ReadLine();
                    break;
                }

            }
        }
    }
}
