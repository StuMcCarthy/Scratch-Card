using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchCard.Core
{
    public class BasicCard
    {
        public readonly WinRateManager winManager;
        public readonly decimal WinValue;
        public readonly bool IsWinner;
        Random random = new Random(DateTime.Now.Millisecond);

        public BasicCard()
        {
            winManager = new WinRateManager();
            switch (winManager.winRarity)
            {
                case 0:
                    WinValue = WinValues.LowWinValues.ElementAt(random.Next(0, WinValues.numberOfWinTypes));
                    break;
                case 1:
                    WinValue = WinValues.MidWinValues.ElementAt(random.Next(0, WinValues.numberOfWinTypes));
                    break;
                case 2:
                    WinValue = WinValues.HighWinValues.ElementAt(random.Next(0, WinValues.numberOfWinTypes));
                    break;
            }
            IsWinner = winManager.isWinner;
        }
    }
}
