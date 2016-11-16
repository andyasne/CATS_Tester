using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zand.CATS_Tester
{
   public class DemoTester
    {
     public   static void run()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            ChromeOptions coptions = new ChromeOptions();
            options.RequireWindowFocus = true;
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.IgnoreZoomLevel = true;
            //caps.SetCapability("ignoreZoomSetting", true);
            chrome = new InternetExplorerDriver(@"E:\Zand\CATS_Tester\CATS_Tester\Libs\", options);
         
            chrome.Navigate().GoToUrl(@"http://localhost:1786/");
            //chrome.Navigate().GoToUrl(@"https://www.google.com/");
            //driver = new InternetExplorerDriver(caps);

            chrome.FindElementByName("UserName").SendKeys("Hub");
            chrome.FindElementByName("Password").SendKeys("P@ssw0rdcats");
            chrome.FindElementById("login-btn").Submit();


            //System.setProperty("webdriver.chrome.driver", "path to chromedriver.exe");

        }

        public static InternetExplorerDriver chrome { get; set; }
    }
}
