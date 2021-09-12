using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WindowsInput;

namespace FaceBook_Automation_Demo.Pages
{
    public class RegisterationPage
    {
        public static void AssertAfterLaunch(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void SignUpintofacebook(IWebDriver driver)
        {
            IWebElement button = driver.FindElement(By.XPath("//*[@class='_6ltg'][2]"));
            button.Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("firstname")).SendKeys("Raju");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("lastname")).SendKeys("S");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("reg_email__")).SendKeys("testprg@gmail.com");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("testprg@gmail.com");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("test@1999");
            System.Threading.Thread.Sleep(1000);
            SelectElement element = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            element.SelectByText("5");
            System.Threading.Thread.Sleep(1000);
            SelectElement element1 = new SelectElement(driver.FindElement(By.Id("month")));
            element1.SelectByValue("11");
            System.Threading.Thread.Sleep(1000);
            SelectElement element2 = new SelectElement(driver.FindElement(By.Id("year")));
            element2.SelectByValue("1999");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("sex")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(12000);





        }

        


    }
}
