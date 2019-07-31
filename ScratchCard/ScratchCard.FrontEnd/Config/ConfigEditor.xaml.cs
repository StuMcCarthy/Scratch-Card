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
using System.Configuration;

namespace ScratchCard.FrontEnd.Config
{
    /// <summary>
    /// Interaction logic for ConfigEditor.xaml
    /// </summary>
    public partial class ConfigEditor : Window
    {
        Configuration config;
        public ConfigEditor()
        {
            InitializeComponent();
            Initilise();
        }

        private void Initilise()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            InitiliseBackgroundStyleBoxes();
            InitiliseWinDifficulty();
        }

        private void InitiliseBackgroundStyleBoxes()
        {
            switch (LoadSetting("SolidOrGradient"))
            {
                case "Solid":
                    checkBoxBackgroundSolid.IsChecked = true;
                    checkBoxBackgroundGradient.IsChecked = false;

                    break;
                case "Gradient":
                    checkBoxBackgroundGradient.IsChecked = true;
                    checkBoxBackgroundSolid.IsChecked = false;
                    break;
                default:
                    break;
            }
        }
        private void InitiliseWinDifficulty()
        {
            switch (LoadSetting("WinDifficulty"))
            {
                case "1":
                    checkBox1Diff.IsChecked = true;
                    checkBox2Diff.IsChecked = false;
                    checkBox5Diff.IsChecked = false;
                    break;
                case "2":
                    checkBox1Diff.IsChecked = false;
                    checkBox2Diff.IsChecked = true;
                    checkBox5Diff.IsChecked = false;
                    break;
                case "5":
                    checkBox1Diff.IsChecked = false;
                    checkBox2Diff.IsChecked = false;
                    checkBox5Diff.IsChecked = true;
                    break;
                default:
                    break;
            }
        }


        private string LoadSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        private void SaveSetting(string key, string value)
        {
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }


        private void SetBackgroundStyle(string style)
        {
            SaveSetting("SolidOrGradient", style);
        }
        private void SetWinDifficulty(string difficulty)
        {
            SaveSetting("WinDifficulty", difficulty);
        }


        private void CheckBoxBackgroundSolid_Checked(object sender, RoutedEventArgs e)
        {
            SetBackgroundStyle("Solid");
            checkBoxBackgroundGradient.IsChecked = false;
        }

        private void CheckBoxBackgroundGradient_Checked(object sender, RoutedEventArgs e)
        {
            SetBackgroundStyle("Gradient");
            checkBoxBackgroundSolid.IsChecked = false;
        }

        private void CheckBox1Diff_Checked(object sender, RoutedEventArgs e)
        {
            SetWinDifficulty("1");
            InitiliseWinDifficulty();
        }

        private void CheckBox2Diff_Checked(object sender, RoutedEventArgs e)
        {
            SetWinDifficulty("2");
            InitiliseWinDifficulty();
        }

        private void CheckBox5Diff_Checked(object sender, RoutedEventArgs e)
        {
            SetWinDifficulty("5");
            InitiliseWinDifficulty();
        }
    }
}
