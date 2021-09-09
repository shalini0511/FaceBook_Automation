using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace FaceBook_Automation_Demo
{
    public class Tests : Base.BaseClass1
    {
        [Test]
        public void InputEmailAndPassword_into_InputFields()
        {
            Pages.LoginPage.AssertAfterLaunching(driver);
            Pages.LoginPage.LoginToFacebook(driver);

        }
        

    }
}
