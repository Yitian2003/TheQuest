using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Mace :Weapon
    {
        public override string Name { get { return "Mace"; } }
        public Mace(Game game, Point location) : base (game, location) { }
        public override void Attack(Direction direction, Random random)
        {
            for (int i = 0; i < 4; i++)
                DamageEnemy((Direction)i, 20, 6, random);
        }
    }
}
