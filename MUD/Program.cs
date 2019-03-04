using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MUD
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("游戏初始化....");
            Initialize initialize = new Initialize();
            Game game = new Game();
            initialize.start();
           
            string option;
            Console.Clear();
            Console.WriteLine("1:进入游戏\r\n");
            Console.WriteLine("2:退出游戏\r\n");
            while (true) {
                option = Console.ReadLine();
                if (int.Parse(option) == 1)
                {
                    game.startGanme();


                }
                else if (int.Parse(option) == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("输入错误请重新输入");
                    continue;
                }
            }
           

        }
    }
}
