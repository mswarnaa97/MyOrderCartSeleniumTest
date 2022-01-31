using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrderCartSeleniumTest.Utils
{
    public class Base
    {
        public static IWebDriver driver;
        public static PageObjects pageObjects;

        public void InitialiseBrowser (string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    //test.Info("The Test Execution is initiated in Chrome Browser");
                    break;

                default:
                    driver = new ChromeDriver();
                    // test.Info("Chrome Browser is Initiated");
                    break;
            }

        }   


    }

}
