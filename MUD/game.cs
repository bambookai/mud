using MUD.Entitys;
using MUD.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD
{
    public class Game
    {
        public void startGanme() {
            Player BOSS = null;
            Player zk = null;
            PK pK = new PK();

            //第一关
            foreach (var item in PlayerFactory.PlaysList)
            {
                if (item.name == "BOSS1")
                {
                    BOSS = item;
                }
            }
            Console.WriteLine("遇到1号BOSS，BOSS的血量{0}\r\n进入战斗。。。。", BOSS.hp);
            
            foreach (var item in PlayerFactory.PlaysList)
            {
                if (item.name == "zk")
                {
                    zk = item;
                }
            }
            
            //战斗更新背包
            for (int i = 0; i < PlayerFactory.PlaysList.Count; i++)
            {
                if (PlayerFactory.PlaysList[i].name == "zk")
                {
                    PlayerFactory.PlaysList[i].bag = pK.startPK(zk, BOSS);
                    break;
                }
            }
           
            //PlayerFactory.PlaysList[0] = zk; 
            //var playerAfter = pK.startPK(zk, BOSS);
            //PlayerFactory.PlaysList.Remove(zk);
            //playerAfter.hp = 100;
            //PlayerFactory.PlaysList.Add(playerAfter);

            //Console.WriteLine("遇到1号BOSS，BOSS的血量{0}\r\n进入战斗。。。。", BOSS.hp);
            //foreach (var item in PlayerFactory.PlaysList)
            //{
            //    if (item.name == "zk")
            //    {
            //        zk = item;
            //    }
            //}
            //var playerAfter = pK.startPK(zk, BOSS);
            //PlayerFactory.PlaysList.Remove(zk);
            //playerAfter.hp = 100;
            //PlayerFactory.PlaysList.Add(playerAfter);

        }
    }
}
