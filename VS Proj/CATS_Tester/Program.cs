using DevExpress.LookAndFeel;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zand.CATS_Tester;

namespace CATS_Tester
{
    static class Program
    {
        private static InternetExplorerDriver chrome;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
  

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Metropolis");
            Application.Run(new Master());
          //Zand.CATS_Tester.DemoTester.  run();
        }
     
    }
}
