using MUD.Entitys;
using MUD.Enum;
using MUD.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD
{
    public class PK
    {
        //物品掉落概率
        public Player DropProbability(Player player)
        {
            int[] probabilityArray = { 1, 1, 1, 1, 1, 2, 2, 3, 3, 4 };
            Random random = new Random();
            int i = random.Next(0, 10);
            int award = probabilityArray[i];
            switch (award)
            {
                case 1:
                    player.bag.weapons["木棍"] = player.bag.weapons["木棍"] + 1;
                    player.bag.lifePotions["包子"] = player.bag.lifePotions["包子"] + 5;
                    Console.WriteLine("获得了1个木棍，5个包子");
                    break;
                case 2:
                    player.bag.weapons["板砖"] = player.bag.weapons["板砖"] + 1;
                    player.bag.lifePotions["烤鸭"] = player.bag.lifePotions["烤鸭"] + 5;
                    Console.WriteLine("获得了1个板砖，5个烤鸭");
                    break;
                case 3:
                    player.bag.weapons["刀"] = player.bag.weapons["刀"] + 1;
                    player.bag.lifePotions["金疮药"] = player.bag.lifePotions["金疮药"] + 1;
                    Console.WriteLine("获得了1个刀，1个金疮药");
                    break;
                case 4:
                    player.bag.weapons["枪"] = player.bag.weapons["枪"] + 1;
                    player.bag.lifePotions["九转还魂丹"] = player.bag.lifePotions["九转还魂丹"] + 1;
                    Console.WriteLine("获得了1把枪，1个九转还魂丹");
                    break;
            }
            return player;
        }

        



        //PK
        public Player startPK(Player player, Player boss) {
            string option;
            
            while (true) {
                Console.WriteLine("1：砍你一刀  2：嗑药  3：技能  4：逃跑");
                if (player.hp <= 0)
                {
                    Console.WriteLine("游戏结束了");
                    return player;
                }
                else if(boss.hp <= 0)
                {
                    Console.WriteLine("战斗胜利");
                    //物品掉落
                    player = DropProbability(player);
                    return player;
                }
                
                option = Console.ReadLine();
                switch (Convert.ToInt32(option)) {
                    case (int)EnumPKOption.砍你一刀:
                        //玩家砍boss
                        boss.hp = boss.hp - player.atk;
                        //boss砍玩家
                        player.hp = player.hp - boss.atk;
                        Console.WriteLine("boos的血还有{0}，zk的血还有{1}", boss.hp, player.hp);
                        continue;
                    case (int)EnumPKOption.嗑药:
                        if (player.bag == null)
                        {
                            Console.WriteLine("你包里啥都没有");
                            continue;
                        }
                        else {
                            Console.WriteLine("包子：" + player.bag.lifePotions["包子"]);
                            Console.WriteLine("\r\n烤鸭：" + player.bag.lifePotions["烤鸭"]);
                            Console.WriteLine("\r\n金疮药：" + player.bag.lifePotions["金疮药"]);
                            Console.WriteLine("\r\n九转还魂丹：" + player.bag.lifePotions["九转还魂丹"]);
                            Console.WriteLine("请选择使用那种药");
                            Console.WriteLine("1：包子   2：烤鸭   3：金疮药  4：九转还魂丹");
                            option = Console.ReadLine();
                            switch (option) {
                                case "1":                                                                       
                                    player.hp = player.hp + LifePotionFactory.LifePotionList[0].hp;
                                    player.bag.lifePotions["包子"] = player.bag.lifePotions["包子"] - 1;                                                                       
                                    continue;
                                case "2":
                                    player.hp = player.hp + LifePotionFactory.LifePotionList[1].hp;
                                    player.bag.lifePotions["烤鸭"] = player.bag.lifePotions["烤鸭"] - 1;
                                    continue;
                                case "3":
                                    player.hp = player.hp + LifePotionFactory.LifePotionList[2].hp;
                                    player.bag.lifePotions["金创药"] = player.bag.lifePotions["金创药"] - 1;                                    
                                    continue;
                                case "4":
                                    player.hp = player.hp + LifePotionFactory.LifePotionList[3].hp;
                                    player.bag.lifePotions["九转还魂丹"] = player.bag.lifePotions["九转还魂丹"] - 1;
                                    continue;
                            }
                        }
                        //boss砍玩家
                        player.hp = player.hp - boss.atk;
                        continue;
                    case (int)EnumPKOption.技能:
                        //要设计个回合数，明天写
                        Console.WriteLine("暂时没技能");
                        continue;
                    case (int)EnumPKOption.逃跑:
                        return player;


                }
            }
        }
    }
}
