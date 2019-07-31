using ScratchCard.Core;
using ScratchCard.FrontEnd.Presentation;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Configuration;

namespace ScratchCard.FrontEnd.Cards
{
    /// <summary>
    /// Interaction logic for Basic_Card.xaml
    /// </summary>
    public partial class Basic_Card : Window
    {
        readonly BasicCard card;
        public Basic_Card()
        {
            InitializeComponent();
            InitialiseView();
            card = new BasicCard();
            labelCashAmount.Content = string.Format("£{0}", card.WinValue);
            labelIsWinner.Content = DisplayIsWinner(card);
            labelWinningNumber.Content = card.winManager.GetWinningNumber();
            labelPlayerNumber.Content = card.winManager.GetPlayersNumber();
        }

        private void InitialiseView()
        {
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            switch (ConfigurationManager.AppSettings["SolidOrGradient"])
            {
                case "Solid":
                    Grid_Panel.Background = new BackgroundDesigner().SetBackgroundColour();
                    break;
                case "Gradient":
                    Grid_Panel.Background = new BackgroundDesigner().SetBackgroundGradient();
                    break;
                default:
                    break;
            }
        }

        private void RevealLabel(Label labelToReveal)
        {
            labelToReveal.Visibility = Visibility.Visible;
        }

        private string DisplayIsWinner(BasicCard card)
        {
            if (card.IsWinner)
                return "You Won!!!";
            else
                return "Better Luck Next Time!";
        }

        private void BtnRevealAmount_Click(object sender, RoutedEventArgs e)
        {
            RevealLabel(labelCashAmount);
            btnRevealWinner.Visibility = Visibility.Visible;
            btnRevealWinner.IsEnabled = true;
        }

        private void BtnRevealWinner_Click(object sender, RoutedEventArgs e)
        {
            RevealLabel(labelIsWinner);
            RevealLabel(labelWinningNumber);
            RevealLabel(labelPlayerNumber);
        }


    }
}
