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

namespace YouTube_Ad_Stripper
{
    /// <summary>
    /// Interaction logic for Main_Window.xaml
    /// </summary>
    public partial class Main_Window : Window
    {
        #region Properties

        /// <summary>
        /// Whether or not the window was cancelled.
        /// </summary>
        public bool WasCancelled { get; private set; }


        /// <summary>
        /// The text that was entered into the text box.
        /// </summary>
        public string DebugText { get; private set; }

        #endregion Properties


        public Main_Window()
        {
            InitializeComponent();

            WasCancelled = true;
        }


        #region Finish Buttons

        private void enter_button_Click(object sender, RoutedEventArgs e)
        {
            WasCancelled = false;

            Close();
        }


        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            WasCancelled = true;

            Close();
        }

        #endregion Finish Buttons


        private void settings_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
