using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FaceBook_Automation_Demo.Base
{
    public class BaseClass1
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
