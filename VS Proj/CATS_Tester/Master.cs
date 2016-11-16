using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Threading;
using OpenQA.Selenium.IE;

namespace Zand.CATS_Tester
{
    public partial class Master : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Master()
        {
            InitializeComponent();
        }

        private void imageListBoxControl1_Click(object sender, EventArgs e)
        {
            if (opened) return;
            opened = true;
            Workflow_Sample wfsample = new Workflow_Sample();
            wfsample.MdiParent = this;
            wfsample.Show();
        }
        static IWebDriver chrome;
        private bool opened = false;

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Sys
            //System.setProperty("webdriver.chrome.driver", "/path/to/chromedriver");

            //WebDriver driver = new ChromeDriver();
            //driver.get("http://www.google.com/xhtml");
            //Thread.sleep(5000);  // Let the user actually see something!
            //WebElement searchBox = driver.findElement(By.name("q"));
            //searchBox.sendKeys("ChromeDriver");
            //searchBox.submit();
            //Thread.sleep(5000);  // Let the user actually see something!
            //driver.quit();

            Zand.CATS_Tester.DemoTester.run();
            return;


            //chrome = new ChromeDriver(@"E:\Zand\CATS_Tester\CATS_Tester\Libs\selenium-dotnet-3.0.0-beta3");

            //chrome = new ChromeDriver(@"E:\Zand\CATS_Tester\CATS_Tester\Libs\");
            //DesiredCapabilities caps = DesiredCapabilities.InternetExplorer();
            InternetExplorerOptions options = new InternetExplorerOptions();
            ChromeOptions coptions = new ChromeOptions();
            options.IgnoreZoomLevel = true;
            //caps.SetCapability("ignoreZoomSetting", true);
            chrome = new InternetExplorerDriver(@"E:\Zand\CATS_Tester\CATS_Tester\Libs\", options);

            //driver = new InternetExplorerDriver(caps);


            //System.setProperty("webdriver.chrome.driver", "path to chromedriver.exe");
            chrome.Navigate().GoToUrl(@"10.24.65.251:99/Release");
            //chrome.Navigate().GoToUrl(@"https://www.google.com/");


        }

        private void imageListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}