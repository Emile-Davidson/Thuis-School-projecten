using System;

namespace dungeon_crawler
{
    class PlayerManager
        {
            private static int PlayerHealt = 0;
            private static int playerX;
            private static int playerY;

            public int healt {
            get { return PlayerHealt; }
            set { PlayerHealt = value; }
            }

            public int X {
            get { return playerX; }
            set { playerX = value; }
            }

            public int Y {
            get { return playerY; }
            set { playerY = value; }
            }
        }
    }
