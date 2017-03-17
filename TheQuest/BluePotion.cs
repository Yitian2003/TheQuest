using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class BluePotion :Weapon, IPotion
    {
        public override string Name { get { return "Blue Potion"; } }
        private bool used = false;
        public bool Used { get; }
        public BluePotion(Game game, Point location) : base (game, location) { }
        public override void Attack(Direction direction, Random random)
        {
            if (!used) game.IncreasePlayerHealth(5, random);
            used = true;
            game.DeleteInventoryPotion("Blue Potion");
        }
    }
}
