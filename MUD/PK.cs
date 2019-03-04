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
        public Bag startPK(Player player, Player boss) {
            string option;
            
            while (true) {
                Console.WriteLine("1：砍你一刀  2：嗑药  3：技能  4：逃跑");
                if (player.hp <= 0)
                {
                    Console.WriteLine("游戏结束了");
                    return player.bag;
                }
                else if(boss.hp <= 0)
                {
                    Console.WriteLine("战斗胜利");
                    return player.bag;
                }
                
                option = Console.ReadLine();
                switch (Convert.ToInt32(option)) {
                    case (int)EnumPKOption.砍你一刀:
                        //玩家砍boss
                        boss.hp = boss.hp - player.atk;
                        //boss砍玩家
                        player.hp = player.hp - boss.atk;
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
                                    foreach (var item in LifePotionFactory.LifePotionList)
                                    {
                                        if (item.name == "包子")
                                        {
                                            player.hp = player.hp + item.hp;
                                            player.bag.lifePotions["包子"] = player.bag.lifePotions["包子"] - 1; 
                                        }
                                    }
                                   
                                    continue;
                                case "2":
                                    foreach (var item in LifePotionFactory.LifePotionList)
                                    {
                                        if (item.name == "烤鸭")
                                        {
                                            player.hp = player.hp + item.hp;
                                            player.bag.lifePotions["烤鸭"] = player.bag.lifePotions["烤鸭"] - 1;
                                        }
                                    }
                                    
                                    continue;
                                case "3":
                                    foreach (var item in LifePotionFactory.LifePotionList)
                                    {
                                        if (item.name == "金疮药")
                                        {
                                            player.hp = player.hp + item.hp;
                                            player.bag.lifePotions["金疮药"] = player.bag.lifePotions["金疮药"] - 1;
                                        }
                                    }
                                    ;
                                    continue;
                                case "4":
                                    foreach (var item in LifePotionFactory.LifePotionList)
                                    {
                                        if (item.name == "九转还魂丹")
                                        {
                                            player.hp = player.hp + item.hp;
                                            player.bag.lifePotions["九转还魂丹"] = player.bag.lifePotions["九转还魂丹"] - 1;
                                        }
                                    }
                                    
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
                        return player.bag;


                }
            }
        }
    }
}
