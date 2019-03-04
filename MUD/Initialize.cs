using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUD.Entitys;
using MUD.factory;

namespace MUD
{
    class Initialize
    {
        public  PlayerFactory playerFactory = new PlayerFactory();
        public LifePotionFactory LifePotionFactory = new LifePotionFactory();
        public WeaponFactory weaponFactory = new WeaponFactory();

        public void start() {

            playerFactory.CreatePlayer("zk",10,100,null,null);
            playerFactory.CreatePlayer("BOSS1", 2, 200, null, null);
            playerFactory.CreatePlayer("BOSS2", 2, 300, null, null);
            playerFactory.CreatePlayer("BOSS3", 2, 400, null, null);
            playerFactory.CreatePlayer("BOSS4", 2, 500, null, null);
            LifePotionFactory.CreateLifePotion("包子", 10);
            LifePotionFactory.CreateLifePotion("烤鸭", 50);
            LifePotionFactory.CreateLifePotion("金疮药", 100);
            LifePotionFactory.CreateLifePotion("九转还魂丹", 1000);
            weaponFactory.CreateWeapon("木棍", 5);
            weaponFactory.CreateWeapon("板砖", 7);
            weaponFactory.CreateWeapon("刀", 9);
            weaponFactory.CreateWeapon("剑", 12);
            weaponFactory.CreateWeapon("枪", 15);


        }
        
    }
}
