using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchCard.Core.TileTypes
{
    public class MoneyTile : Tile
    {
        public string Name
        {
            get
            {
                switch (Index)
                {
                    case 0:
                        return "£2";
                    case 1:
                        return "£5";
                    case 2:
                        return "£20";
                    case 3:
                        return "£100";
                    case 4:
                        return "£500";
                    case 5:
                        return "£10000";
                    case 6:
                        return "£100000";
                    default:
                        return "";
                }
            }
        }

        public MoneyTile(Random seed)
            : base(seed)
        {

        }
    }
}
