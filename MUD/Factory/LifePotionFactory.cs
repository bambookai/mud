using MUD.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD.factory
{
    public class LifePotionFactory
    {
        public static IList<LifePotion> LifePotionList = new List<LifePotion>();

        public LifePotionFactory()
        {

        }

        public void CreateLifePotion(string name, int hp)
        {
            LifePotion lifePotion = new LifePotion();
            lifePotion.name = name;
            lifePotion.hp = hp;
            LifePotionList.Add(lifePotion);
        }

        public void RomoveLifePotion(string name)
        {
            foreach (var item in LifePotionList)
            {
                if (item.name == name)
                {
                    LifePotionList.Remove(item);
                }
            }
        }
    }
}

