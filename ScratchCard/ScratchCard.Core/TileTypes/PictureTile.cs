using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchCard.Core.TileTypes
{
    public class PictureTile : Tile
    {
        public string Name
        {
            get
            {
                switch (Index)
                {
                    case 0:
                        return "House";
                    case 1:
                        return "Car";
                    case 2:
                        return "Dog";
                    case 3:
                        return "Plane";
                    case 4:
                        return "Cake";
                    case 5:
                        return "Man";
                    case 6:
                        return "Seat";
                    default:
                        return "";
                }
            }
        }

        public PictureTile()
            : base()
        {

        }
    }
}
