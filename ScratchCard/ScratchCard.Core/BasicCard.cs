using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchCard.Core
{
    public class BasicCard
    {
        WinRateManager winManager;
        public readonly decimal WinValue;

        public BasicCard()
        {
            winManager = new WinRateManager();
            switch (winManager.winRarity)
            {
                case 0:
                    WinValue = WinValues.LowWinValues.ElementAt(new Random().Next(0, 2));
                    break;
                case 1:
                    WinValue = WinValues.MidWinValues.ElementAt(new Random().Next(0, 2));
                    break;
                case 2:
                    WinValue = WinValues.HighWinValues.ElementAt(new Random().Next(0, 2));
                    break;
            }

        }
    }
}
