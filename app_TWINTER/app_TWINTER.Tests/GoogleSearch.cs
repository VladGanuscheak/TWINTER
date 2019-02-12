using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace app_TWINTER.Tests
{
    [TestClass]
    public class GoogleSearch
    {
        /*[TestMethod]
        public void Search_Using_Firefox()
        {
            // Initializing the Chrome Driver
            using (var driver = new FirefoxDriver())
            {
                // 1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://localhost:54719/");
            }
        }*/

        [TestMethod]
        public void Search_Using_Chrome()
        {
            // Initializing the Chrome Driver
            using (var driver = new ChromeDriver(@"D:\GIThub\TWINTER\app_TWINTER\packages\Selenium.Chrome.WebDriver.2.45\driver"))
            {
                // 1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the Localhos
                driver.Navigate().GoToUrl("http://localhost:54719/");

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.FindElement(By.Id("email")).SendKeys("noemail@gmil.com");

                driver.FindElement(By.Id("password")).SendKeys("Lol97NoPassword");
                    
                driver.FindElement(By.Id("Enter")).Click();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

                driver.FindElement(By.Id("DoTwint")).Click();
                while (true);
            }
        }
    }
}
