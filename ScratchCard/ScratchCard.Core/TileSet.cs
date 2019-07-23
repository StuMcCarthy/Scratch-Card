using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchCard.Core.TileTypes;

namespace ScratchCard.Core
{
    public class TileSet
    {
        readonly List<Tile> Tiles;
        protected int winChance;

        protected readonly int lowWinIndex = 0;
        protected readonly int midWinIndex = 1;
        protected readonly int highWinIndex = 2;

        Random random;

        public TileSet(int numberOfTiles)
        {
            Tiles = new List<Tile>(numberOfTiles);
            Random random = new Random();
            for (int i = 0; i < numberOfTiles; i++)
            {
                var tile = new MoneyTile(random);
                Tiles.Add(tile);
            }
        }

        public void IsWinner()
        {
            int winningSeed = random.Next(0, 2);
            switch (winningSeed)
            {
                case 0:
                    winChance = 10;
                    break;
                case 1:
                    winChance = 100;
                    break;
                case 2:
                    winChance = 1000;
                    break;
            }

        }






//        int CorrectComparisons = 0;
//        int winningIndex = 9;
//            for (int i = 0; i<Tiles.Count; i++)
//            {
//                var t = Tiles.ElementAt(i);
//                foreach (Tile tile in Tiles.Skip(i))
//                {
//                    if (t.Index == tile.Index)
//                    {
//                        CorrectComparisons++;
//                    }
//}
//                if (CorrectComparisons >= 3)
//                {
//                    winningIndex = t.Index;
//                    return;
//                }
//                else
//                    CorrectComparisons = 0;
//            }
    }
}
