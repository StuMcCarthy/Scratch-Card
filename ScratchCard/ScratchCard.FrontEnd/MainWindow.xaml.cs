using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Configuration;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScratchCard.Core;
using ScratchCard.FrontEnd.Cards;

namespace ScratchCard.FrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = ConfigurationManager.AppSettings["BaseWindowName"];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Basic_Card basic_CardForm = new Basic_Card();
            basic_CardForm.Show();
        }
    }
}
