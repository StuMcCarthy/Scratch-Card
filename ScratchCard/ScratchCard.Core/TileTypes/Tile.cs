using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchCard.Core.TileTypes
{
    public class Tile
    {
        public int Index { get; set; }

        public Tile(Random seed)
        {
            Index = seed.Next(0,6);
        }
    }
}
