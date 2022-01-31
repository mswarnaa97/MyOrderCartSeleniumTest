using MyOrderCartSeleniumTest.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrderCartSeleniumTest
{
   
    [TestFixture]
    public class MyOrderTest :Base
    {
        TestMethods testMethod = new TestMethods();
        Hooks hooks = new Hooks();
        [SetUp, Order(1)]
        public void Setup()
        {
            InitialiseBrowser("chrome");
            hooks.OpenPage("https://localhost:49161/");
            hooks.MaximiseWindow();
            hooks.ImplicitWait(10);
            //Page Elemenets Initialization
            pageObjects = new PageObjects();                
        }

        [Test, Order(1)]  
        public void IS_Page_Launched()
        {
            Assert.IsTrue(pageObjects.MyOrderCart.Displayed);
        }

        [Test, Order(2)]
        public void Add_Cart()
        {
            testMethod.AddItem("Fjallraven - Foldsack No. 1 Backpack, Fits 15 Lapt");   
        }

        [Test, Order(3)]    
        public void Remove_Cart()
        {
            testMethod.AddItem("Fjallraven - Foldsack No. 1 Backpack, Fits 15 Lapt");
            testMethod.RemoveItem();
        }               
        

        [TearDown]
        public void AfterTest()
        {
            hooks.CloseBroswer();
            driver = null;
        }

    }
}
