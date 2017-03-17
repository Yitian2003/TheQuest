using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location):base(game,location,8) { }
        public override void Move(Random random)
        {
            if (Dead) return;
            if (random.Next(1, 3) == 1) base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            if (NearPlayer()) game.HitPlayer(3, random);
        }
    }
}
