using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting
{
    public class CustomControl : DriverHelper
    {
        //Set parameter for ComboBox method
        public static void ComboBox(String controlName, String value)
        {
            //Create new label for finding control element
            IWebElement comboControl = Driver.FindElement(By.Id($"{controlName}-awed"));
            comboControl.Clear();
            comboControl.SendKeys(value);

            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
