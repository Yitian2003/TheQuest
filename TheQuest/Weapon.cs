using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        public abstract string Name { get; }
        public Weapon(Game game, Point location) : base(game,location)
        {
            PickedUp = false;
        }
        public void PickUpWeapon()  { PickedUp = true; }
        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy( Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance =0; distance<= radius;distance++)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance) && (!enemy.Dead))
                    { enemy.Hit(damage, random); return true; }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        private Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            switch (direction)
            {
                case Direction.Up:
                    if (target.Y - 1 >= boundaries.Top) target.Y -= 1;
                    break;
                case Direction.Down:
                    if (target.Y + 1 <= boundaries.Bottom) target.Y += 1;
                    break;
                case Direction.Left:
                    if (target.X - 1 >= boundaries.Left) target.X -= 1;
                    break;
                case Direction.Right:
                    if (target.X + 1 <= boundaries.Right) target.X += 1;
                    break;
                default: break;
            }
            return target;
        }

        public bool Nearby(Point locationA, Point locationB, int distance)
        {
            if (Math.Abs(locationA.X - locationB.X) < distance && Math.Abs(locationA.Y - locationB.Y) < distance)
            {
                return true;
            }
            else return false;
        }
    }
}
