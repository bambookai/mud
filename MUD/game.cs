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
        public Player BOSS = new Player();
        public Player zk = new Player();
        public PK pK = new PK();

        //更新zk信息
        public Player updateplayer() {
            PlayerFactory.PlaysList[0].hp = 100;
            return zk = PlayerFactory.PlaysList[0];
        }

        //关卡,i代表关卡数
        public Player level(Player zk, int i)
        {
            string option;
            Console.WriteLine("1：打  2帮助他  3不理他");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    //第一关          
                    BOSS = PlayerFactory.PlaysList[i];
                    Console.WriteLine("遇到号{0}BOSS，BOSS的血量{1}\r\n进入战斗。。。。", i, BOSS.hp);

                    //战斗并更新背包           
                    zk = pK.startPK(zk, BOSS);
                    return zk;
                case "2":
                    PlayerFactory.PlaysList[0].bag.lifePotions["包子"] = PlayerFactory.PlaysList[0].bag.lifePotions["包子"] + 5;
                    return zk;
                case "3":
                    Console.WriteLine("前往下一关");
                    return zk;
            }
            return zk;
        }

        ////查看背包
        public void showBag(Player zk)
        {
            foreach (var item in zk.bag.lifePotions) {
                Console.WriteLine("{0}有{1}个", item.Key, item.Value);
            }

        }
        public Player walk(Player zk,int i){
            string option;
            while (true)
            {
                if (i == 1)
                {
                    Console.WriteLine("1:往前走 2查看背包 ");
                }
                else
                {
                    Console.WriteLine("1:往前走 2查看背包 3往后走 ");
                }               
                option = Console.ReadLine();
                if (option == "1")
                {
                    level(zk, i);
                    zk = updateplayer();
                    return zk;

                }
                else if (option == "2")
                {
                    showBag(zk);
                    continue;
                }
                else if (option == "3")
                {
                    if (i == 0)
                    {
                        Console.WriteLine("输入错误请重新输入");
                        continue;
                    }
                    else {
                        level(zk, i - 1);
                        //回到初始血
                        zk = updateplayer();
                        return zk;
                    }
                    
                }
                else
                {
                    Console.WriteLine("输入错误请重新输入");
                    continue;
                }
            }
        }


        public void startGanme() {         
            zk=updateplayer();
            string option;
            Console.WriteLine("剧情\r\n");
            walk(zk,1);
            walk(zk, 1);
            walk(zk, 1);
            walk(zk, 1);


            level(zk,1);
            zk = updateplayer();
            showBag(zk);
            Console.WriteLine("剧情\r\n");
            level(zk,2);






            Console.WriteLine("zk的血量:"+PlayerFactory.PlaysList[0].hp);
            zk=updateplayer();
            Console.WriteLine("zk的血量:"+zk.hp);
            
           




        }
    }
}
