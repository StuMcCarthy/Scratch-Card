using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ScratchCard.Core
{
    class WinRateManager
    {
        public bool isWinner { get; private set; }
        public int winRarity { get; private set; }


        private int winningIndex;
        private int numberToMatch;

        private readonly int lowWinIndex = 0;
        private readonly int midWinIndex = 1;
        private readonly int highWinIndex = 2;

        private int winDivider;

        Random random;
        public WinRateManager()
        {
            LoadConfiguration();
            random = new Random();
            SetWinRarity();
            SetIfWinner();
        }

        private void LoadConfiguration()
        {
            winDivider = int.Parse(ConfigurationManager.AppSettings["WinDifficulty"]);
        }

        private void SetWinRarity()
        {
            winningIndex = random.Next(0, 999);
            if (winningIndex < 900)
            {
                winRarity = lowWinIndex;
            }
            else if (winningIndex < 950)
            {
                winRarity = midWinIndex;
            }
            else if (winningIndex > 990)
            {
                winRarity = highWinIndex;
            }
        }

        private void SetIfWinner()
        {
            
            switch (winRarity)
            {
                case 0:
                    winDivider = winDivider * 100;
                    break;
                case 1:
                    winDivider = winDivider * 10;
                    break;
                case 2:
                    winDivider = winDivider * 1;
                    break;
            }

            numberToMatch = random.Next(0, 999);

            if ((winningIndex / winDivider) == (numberToMatch / winDivider))
                isWinner = true;
            else
                isWinner = false;
        }
    }
}
