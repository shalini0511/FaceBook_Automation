using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace FaceBook_Automation_Demo
{
    public class Tests : Base.BaseClass1
    {
        /*[Test]
        public void InputEmailAndPassword_into_InputFields()
        {
            DoActions.DoAction.AssertAfterLaunching(driver);
            DoActions.DoAction.LoginToFacebook(driver);
           
        }*/
        [Test]
        public void InputSignUp_Details()
        {
            Pages.RegisterationPage.AssertAfterLaunch(driver);
            Pages.RegisterationPage.SignUpintofacebook(driver);
        }

        

    }
}
