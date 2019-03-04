using MUD.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD.factory
{
    public class WeaponFactory
    {
        public static IList<Weapon> WeaponList = new List<Weapon>();

        public WeaponFactory()
        {

        }

        public void CreateWeapon(string name, int atk)
        {
            Weapon weapon = new Weapon();
            weapon.name = name;
            weapon.atk = atk;
            WeaponList.Add(weapon);
        }

        public void RomoveWeapon(string name)
        {
            foreach (var item in WeaponList)
            {
                if (item.name == name)
                {
                    WeaponList.Remove(item);
                }
            }
        }
    }
}

