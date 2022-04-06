using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationTesting
{
    public class Tests: DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            //Initialize new object to CustomControl class
            //CustomControl control = new CustomControl(); - will need to remove this if driverhelper is static
            //Set value for ComboBox
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");



            
            Console.WriteLine("Sample update for github");

            /*
             login CRM
             Driver.FindElement(By.Id("i0116")).SendKeys("GAranas@lowyinstitute.org");
             Driver.FindElement(By.Id("idSIButton9")).Click();
             Driver.FindElement(By.Id("i0118")).SendKeys("ShortRock99");
             Driver.FindElement(By.Id("idSIButton9")).Click(); 
              Driver.Quit
            */

        }
    }
}