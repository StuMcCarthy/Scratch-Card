using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ScratchCard.Core;

namespace ScratchCard.FrontEnd.Cards
{
    /// <summary>
    /// Interaction logic for Basic_Card.xaml
    /// </summary>
    public partial class Basic_Card : Window
    {
        BasicCard card;

        public Basic_Card()
        {
            InitializeComponent();
            card = new BasicCard();
            labelCashAmount.Content = string.Format("£{0}", card.WinValue);
            labelIsWinner.Content = DisplayIsWinner(card);
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
        }
    }
}
