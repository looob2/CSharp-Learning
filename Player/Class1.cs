using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Player
    {
        private string name;
        private int hp;
        private int attack;
        private int defence;

        public Player()
        {
            name = "Ghost";
            hp = 10;
            attack = 5;
            defence = 5;
        }
        public Player(string name , int hp , int attack , int defence)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defence = defence;
        }
    }
}
