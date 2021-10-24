using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YouTube_Ad_Stripper
{
    class Program
    {
        private static Regex addocid_regex = new Regex("\"addocid\": \"(.+)\"", RegexOptions.Compiled);


        [STAThread]
        static void Main(string[] args)
        {
            Match match = null;


            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                match = addocid_regex.Match(Clipboard.GetText());

                if (match.Success)
                {
                    Process.Start("chrome.exe", "https://www.youtube.com/watch?v=" + match.Groups[1].Value);

                    return;
                }
            }


            Main_Window window = new Main_Window();
            window.ShowDialog();

            if (window.WasCancelled)
            {
                return;
            }


            match = addocid_regex.Match(window.DebugText);

            if (match.Success)
            {
                Process.Start("chrome.exe", "https://www.youtube.com/watch?v=" + match.Groups[1].Value);
            }
        }
    }
}
