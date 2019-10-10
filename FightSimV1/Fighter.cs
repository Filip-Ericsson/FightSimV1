using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Fighter
    {
        //Variabler till fighters
        private int hp = 100; 
        public string name = "";
        public static Random gen = new Random();

        public int Attack() //Slumpar hur mycket skada en fighter gör i sitt nästa slag
        {
            return gen.Next(5, 20); //Kan göra mellan 5 till 20 skada
        }

        public void Hurt(int amount) //Subtraherar en fighters hp med hur mycket skada andra spelaren gör. 
        {
            hp -= amount; //Amount är andra fighterns attack

            if (hp <0)
            {
                hp = 0;
            }
        } 

        public bool IsAlive() //Kollar om en fighter är vid liv
        {
            if (hp <= 0) // Om hp är mindre än eller lika med noll anses fightern som död
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetHp() // returnerar en fighters hp
        {
            return hp;
        }
    }
}
