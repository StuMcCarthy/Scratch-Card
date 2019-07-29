using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ScratchCard.FrontEnd.Presentation
{
    class BackgroundDesigner
    {
        readonly Random random = new Random();

        public SolidColorBrush SetBackgroundColour()
        {
            // int a = 50;
            Color color = new Color();
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        color.R = (byte)random.Next(0, 255);
                        break;
                    case 1:
                        color.G = (byte)random.Next(0, 255);
                        break;
                    case 2:
                        color.B = (byte)random.Next(0, 255);
                        break;
                    case 3:
                        color.A = (byte)random.Next(50, 255);
                        break;
                    default:
                        break;
                }
            }
            return new SolidColorBrush(color);
        }

        public LinearGradientBrush SetBackgroundGradient()
        {
            Color colorStart = new Color();
            Color colorEnd = new Color();
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        colorStart.R = (byte)random.Next(0, 255);
                        break;
                    case 1:
                        colorStart.G = (byte)random.Next(0, 255);
                        break;
                    case 2:
                        colorStart.B = (byte)random.Next(0, 255);
                        break;
                    case 3:
                        colorStart.A = (byte)random.Next(50, 255);
                        break;
                    default:
                        break;
                }
            }
            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0:
                        colorEnd.R = (byte)random.Next(0, 255);
                        break;
                    case 1:
                        colorEnd.G = (byte)random.Next(0, 255);
                        break;
                    case 2:
                        colorEnd.B = (byte)random.Next(0, 255);
                        break;
                    case 3:
                        colorEnd.A = (byte)random.Next(50, 255);
                        break;
                    default:
                        break;
                }
            }
            return new LinearGradientBrush(colorStart, colorEnd, 90);
        }
    }
}
