using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyOrderCartSeleniumTest.Utils
{
    public class Hooks : Base
    {
        public void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBroswer() => driver.Quit();

        public  void MaximiseWindow()
        {
            driver.Manage().Window.Maximize();
        }

        //Minimise Window
        public void MinimiseWindow()
        {
            driver.Manage().Window.Minimize();
        }

        public void Click(IWebElement element)
        {            
            element.Click();            
        }

        public  void SendKeys(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
        public  void ImplicitWait( double time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }
    }
}
