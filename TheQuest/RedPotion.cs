using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class RedPotion: Weapon, IPotion
    {
        public override string Name { get { return "Red Potion"; } }
        private bool used = false;
        public bool Used { get { return used; } }
        public RedPotion(Game game, Point location) : base (game, location) { }
        public override void Attack(Direction direction, Random random)
        {
            if (!used) game.IncreasePlayerHealth(10, random);
            used = true;
        }
    }
}
