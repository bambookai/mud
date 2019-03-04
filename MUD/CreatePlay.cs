using MUD.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD
{
    public class CreatePlay
    {
        public Player createPlays(int atk, int hp, Weapon weapon, Bag bag)
        {
            Player player = new Player
            {
                atk = atk,
                hp = hp,
                weapon = weapon,
                bag = bag
            };
            return player;
        }
    }
}
