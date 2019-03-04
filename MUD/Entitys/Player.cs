using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD.Entitys
{
    public class Player
    {
        public string name { get; set; }
        public int atk { get; set; }
        public int hp { get; set; }
        public  Weapon weapon { get; set; }
        public  Bag bag { get; set; }
    }
}
