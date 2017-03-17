using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        private List<Weapon> inventory = new List<Weapon>();
        public int HitPoints { get; private set; }
        private int fullHitPoint = 1000;
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory) names.Add(weapon.Name);
                return names;
            }
        }

        public Player (Game game,Point location):base (game,location)
        {
            HitPoints = fullHitPoint;
        }
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 1))
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                    if (inventory.Count == 1) Equip(game.WeaponInRoom.Name); 
                }
            }
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
                if (weapon.Name == weaponName) equippedWeapon = weapon;
        }
        public string EquipWeapon()
        {
            if (equippedWeapon != null) return equippedWeapon.Name;
            else return "";
        }
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
            if (HitPoints > fullHitPoint) HitPoints = fullHitPoint;
        }
        public void DeleteInventoryPotion(string potion)
        {
            for (int i = 0; i < inventory.Count; i++)
                if (inventory[i].Name == potion) inventory.RemoveAt(i);
        }
        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                switch (equippedWeapon.Name)
                {
                    case "Sword":
                        Sword sword = (Sword)equippedWeapon;
                        sword.Attack(direction, random);
                        break;
                    case "Bow":
                        Bow bow = (Bow)equippedWeapon;
                        bow.Attack(direction, random);
                        break;
                    case "Mace":
                        Mace mace = (Mace)equippedWeapon;
                        mace.Attack(direction, random);
                        break;
                    case "Blue Potion":
                        BluePotion bluePotion = (BluePotion)equippedWeapon;
                        bluePotion.Attack(direction, random);
                        break;
                    case "Red Potion":
                        RedPotion redPotion = (RedPotion)equippedWeapon;
                        redPotion.Attack(direction, random);
                        break;
                }
            }
          }
    }
}
