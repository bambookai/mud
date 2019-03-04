using MUD.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD.factory
{
    public class PlayerFactory
    {
        public static IList<Player> PlaysList = new List<Player>();

        public PlayerFactory()
        {

        }

        public void CreatePlayer(string name,int atk,int hp, Weapon weapon,Bag bag) {
            Player player = new Player();
            player.name = name;
            player.atk = atk;
            player.hp = hp;
            player.weapon = weapon;
            player.bag = bag;
            PlaysList.Add(player);
        }

        public void RomovePlayer(string name)
        {
            foreach (var item in PlaysList)
            {
                if (item.name == name) {
                    PlaysList.Remove(item);
                }
            }
        }
    }
}
