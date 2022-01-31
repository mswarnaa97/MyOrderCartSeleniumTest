using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrderCartSeleniumTest.Utils
{
    public class TestMethods :Base
    {
        Hooks hooks = new Hooks();
        
        public void AddItem(string productName)
        {
            hooks.Click(pageObjects.SelectProduct(productName));
            hooks.Click(pageObjects.AddItem);
            var val = pageObjects.CartValue.Text;
            if (val != null)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        public void RemoveItem()
        {
            hooks.Click(pageObjects.RemoveItem);    
        }
    }
}
