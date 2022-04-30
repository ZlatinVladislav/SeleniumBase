using System;
using AutomationFramework.Configuration;
using OpenQA.Selenium;

namespace SeleniumWebdriver.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement element;

        public static void SelectCheckBox(By locator, string elementName)
        {
            GenericHelper.WaitForWebElement(locator, elementName);
            element = GenericHelper.GetElement(locator, elementName);
            element.Click();
        }

        public static bool IsCheckBoxChecked(By locator, string elementName)
        {
            GenericHelper.WaitForWebElement(locator, elementName);
            element = GenericHelper.GetElement(locator, elementName);
            string flag = element.GetAttribute("checked");

            if (flag == null)
            {
                return false;
            }
            else
            {
                return flag.Equals("true") || flag.Equals("checked");
            }
        }
    }
}

