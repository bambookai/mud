using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD.Entitys
{
    public class Bag
    {
       public Dictionary<string, int> lifePotions = new Dictionary<string, int>();
       public Dictionary<string, int> weapons = new Dictionary<string, int>();
    }
}
