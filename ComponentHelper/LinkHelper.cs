using System;
using AutomationFramework.Configuration;
using OpenQA.Selenium;

namespace SeleniumWebdriver.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement element;

        public static void ClickLink(By locator, string elementName)
        {
            GenericHelper.WaitForWebElement(locator, elementName);
            element = GenericHelper.GetElement(locator, elementName);
            element.Click();
        }

        public static bool Visible(By locator, string elementName)
        {
            GenericHelper.WaitForWebElement(locator, elementName);
            return GenericHelper.IsElementPresent(locator);
        }
    }
}
