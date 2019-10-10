using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Fighter
    {
        private int hp = 100;
        public string name = "";
        public static Random gen = new Random();

        public int Attack()
        {
            return gen.Next(5, 20);
        }

        public void Hurt(int amount)
        {
            hp -= amount;

            if (hp <0)
            {
                hp = 0;
            }
        } 

        public bool IsAlive()
        {
            if (hp <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetHp()
        {
            return hp;
        }
    }
}
