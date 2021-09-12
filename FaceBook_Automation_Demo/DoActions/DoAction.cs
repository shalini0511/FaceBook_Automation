using System;
using System.Collections.Generic;
using System.Text;
using FaceBook_Automation_Demo.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FaceBook_Automation_Demo.DoActions
{
    public class DoAction
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void LoginToFacebook(IWebDriver driver)
        {
            LoginPage login = new LoginPage(driver);
            login.email.SendKeys("9384613347");
            System.Threading.Thread.Sleep(2000);
            login.password.SendKeys("test@123");
            System.Threading.Thread.Sleep(2000);
            login.loginBtn.Click();
            System.Threading.Thread.Sleep(9000);

        }
    }
}
