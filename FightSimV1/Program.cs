﻿using System;
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
            //Skapar två fighters
            Fighter FighterA = new Fighter();
            FighterA.PickName();
            Fighter FighterB = new Fighter();
            FighterB.PickName();

            while (FighterA.FighterName()== FighterB.FighterName())
            {
                Console.WriteLine("New name");
                FighterB.PickName();
            }
            bool stillFighting = true; //en boolean som blir false när en fighter är död

            while (stillFighting)
            {
                FighterB.Hurt(FighterA.Attack()); //FighterB tar FighterAs attackskada

                FighterA.Hurt(FighterB.Attack()); //se ovan

                Console.WriteLine(FighterA.FighterName() + " Hp is: " + FighterA.GetHp() ) ; //skriver varje fighters hp
                Console.WriteLine(FighterB.FighterName() + " Hp is: " + FighterB.GetHp() + "\n");


                //Kollar om någon fighter är död
                if (FighterA.IsAlive() == false)
                {
                    Console.WriteLine(FighterB.FighterName() + " is our winner!");
                    Console.ReadLine();
                    stillFighting = false;
                }
                else if (FighterB.IsAlive() == false )
                {
                    Console.WriteLine(FighterA.FighterName() + " winns this battle!");
                    Console.ReadLine();
                    stillFighting = false;
                }
                //Om ingen är död körs loopen igen.
                
            }
        }
    }
}
