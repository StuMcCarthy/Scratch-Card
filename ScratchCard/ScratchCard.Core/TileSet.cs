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
        WinRateManager winManager;

        public TileSet(int numberOfTiles)
        {
            winManager = new WinRateManager();

            Tiles = new List<Tile>(numberOfTiles);
            for (int i = 0; i < numberOfTiles; i++)
            {
                var tile = new MoneyTile();
                Tiles.Add(tile);
            }
        }



    }
}
