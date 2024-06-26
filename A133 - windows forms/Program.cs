using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A133___windows_forms
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }

    public static class Forms
    {
        public static MainMenu MM = new MainMenu();
        public static CreateQuiz CQ = new CreateQuiz();
        public static PlayQuiz PQ = new PlayQuiz();
    }
}
