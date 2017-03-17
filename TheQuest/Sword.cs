using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Sword :Weapon
    {
        public override string Name { get { return "Sword"; } }
        public Sword(Game game, Point location) : base (game, location) { }
        public override void Attack(Direction direction, Random random)
        {
            Direction couterclockwise, clockwise;
            if (direction == Direction.Left) clockwise = Direction.Up;
            else clockwise = direction + 1;
            if (direction == Direction.Up) couterclockwise = Direction.Left;
            else couterclockwise = direction - 1;

            if (!DamageEnemy(direction, 20, 5, random))
                if (!DamageEnemy(clockwise, 20, 5, random))
                    DamageEnemy(couterclockwise, 20, 5, random);
        }
    }
}
