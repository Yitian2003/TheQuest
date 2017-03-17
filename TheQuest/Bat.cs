using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location):base(game,location,6) { }
        public override void Move(Random random)
        {
            if (Dead) return;
            if (random.Next(0, 1) == 0) base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            else Move((Direction)random.Next(0, 3), game.Boundaries);
            if (NearPlayer()) game.HitPlayer(2,random);
        }
    }
}
