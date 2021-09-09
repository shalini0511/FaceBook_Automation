using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FaceBook_Automation_Demo.Pages
{
    public class LoginPage
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("9384613347");
            IWebElement password = driver.FindElement(By.Id("pass"));
            email.SendKeys("test@123");
            IWebElement login = driver.FindElement(By.Name("login"));
            login.Click();

        }
    }
}
