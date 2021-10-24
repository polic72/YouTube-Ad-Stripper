using System;
using System.Collections.Generic;
using System.IO;
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


namespace YouTube_Ad_Stripper
{
    /// <summary>
    /// Interaction logic for Settings_Window.xaml
    /// </summary>
    public partial class Settings_Window : Window
    {
        #region Constants

        /// <summary>
        /// The name of the settings file.
        /// </summary>
        public const string SETTINGS_FILENAME = "Settings.txt";


        /// <summary>
        /// The character a line starts with to be a comment.
        /// </summary>
        public const char COMMENT_CHARACTER = '#';

        #endregion Constants


        #region Properties

        /// <summary>
        /// Whether or not to use the cliboard.
        /// </summary>
        public bool UseClipboard { get; private set; }

        #endregion Properties


        public Settings_Window()
        {
            InitializeComponent();
        }


        #region Finish Buttons

        private void enter_button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader reader = new StreamReader(SETTINGS_FILENAME))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (!line.StartsWith(COMMENT_CHARACTER.ToString()))
                    {
                        //Bruh, I'll do this later.
                    }
                }
            }

            Close();
        }


        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion Finish Buttons
    }
}
