using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrderCartSeleniumTest.Utils
{
    public class PageObjects :Base
    {
        public PageObjects()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'MyOrderCart')]")]
        public IWebElement MyOrderCart { get; set; }

        [FindsBy(How=How.PartialLinkText, Using = "Home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Count")]
        public IWebElement Counter { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Fetch da")]
        public IWebElement FetchData { get; set; }

        public IWebElement SelectProduct( string productName)
        {
            IWebElement product = driver.FindElement(By.XPath("//option[contains(text(),'"+ productName +"')]"));
            return product;
        }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add')]")]
        public IWebElement AddItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Remove')]")]
        public IWebElement RemoveItem { get; set; }

        [FindsBy(How = How.TagName, Using = "input")]
        public IWebElement QuantityOfItem { get; set; }

        [FindsBy(How = How.TagName, Using = "h4")]
        public IWebElement CartValue { get; set; }



    }
}
