using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace FaceBook_Automation_Demo.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        { 
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginBtn;

    }
}
