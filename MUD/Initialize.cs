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
        public Bag bag = new Bag();
        public Weapon weapon = new Weapon();

        public void start() {

            //基础物品属性初始化
            LifePotionFactory.CreateLifePotion("包子", 10);
            LifePotionFactory.CreateLifePotion("烤鸭", 50);
            LifePotionFactory.CreateLifePotion("金疮药", 100);
            LifePotionFactory.CreateLifePotion("九转还魂丹", 1000);
            weaponFactory.CreateWeapon("木棍", 5);
            weaponFactory.CreateWeapon("板砖", 7);
            weaponFactory.CreateWeapon("刀", 9);
            weaponFactory.CreateWeapon("剑", 12);
            weaponFactory.CreateWeapon("枪", 15);

            //角色信息初始化
            playerFactory.CreatePlayer("zk", 10, 100, weapon, bag);
            playerFactory.CreatePlayer("BOSS1", 2, 30, null, null);
            playerFactory.CreatePlayer("BOSS2", 2, 300, null, null);
            playerFactory.CreatePlayer("BOSS3", 2, 400, null, null);
            playerFactory.CreatePlayer("BOSS4", 2, 500, null, null);

            PlayerFactory.PlaysList[0].bag.lifePotions.Add("包子", 0);
            PlayerFactory.PlaysList[0].bag.lifePotions.Add("烤鸭", 0);
            PlayerFactory.PlaysList[0].bag.lifePotions.Add("金疮药", 0);
            PlayerFactory.PlaysList[0].bag.lifePotions.Add("九转还魂丹", 0);
            PlayerFactory.PlaysList[0].bag.weapons.Add("木棍", 0);
            PlayerFactory.PlaysList[0].bag.weapons.Add("板砖", 0);
            PlayerFactory.PlaysList[0].bag.weapons.Add("刀", 0);
            PlayerFactory.PlaysList[0].bag.weapons.Add("剑", 0);
            PlayerFactory.PlaysList[0].bag.weapons.Add("枪", 0);
        }
        
    }
}
