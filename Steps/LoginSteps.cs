using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecflowBDD.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SpecflowBDD.Steps
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage = new LoginPage();
        HomePage swagLabsHomePage = new HomePage();
        bool result = false;

        #region Given

        [Given(@"a user in the Login Page")]
        public void GivenAUserInTheLoginPage()
        {
            Assert.IsTrue(loginPage.IsLogoCompanyPresent());
        }

        #endregion

        #region When

        [When(@"the user enters an incorrect UserName")]
        public void WhenTheUserEntersAnIncorrectUserName()
        {
            loginPage.typeInUserFieldIncorrectName();
        }
        
        [When(@"the user enters expected Password")]
        public void WhenTheUserEntersExpectedPassword()
        {
            loginPage.typeInPasswordFieldExpectedPassword();
        }
        
        [When(@"click on Login Button")]
        public void WhenClickOnLoginButton()
        {
            swagLabsHomePage = loginPage.clickOnLoginButton();
        }
        
        [When(@"the user enters expected UserName")]
        public void WhenTheUserEntersExpectedUserName()
        {
            loginPage.typeInUserFieldExpectedName();
        }
        
        [When(@"the user enters an incorrect Password")]
        public void WhenTheUserEntersAnIncorrectPassword()
        {
            loginPage.typeInPasswordFieldIncorrectPassword();
        }
        
        [When(@"the user doesn't enter UserName in the Username field")]
        public void WhenTheUserDoesnTEnterUserNameInTheUsernameField()
        {
            
        }
        
        [When(@"the user doesn't enter Password in the Password field")]
        public void WhenTheUserDoesnTEnterPasswordInThePasswordField()
        {
            
        }

        #endregion

        #region Then

        [Then(@"the system throws the error ""(.*)"" message")]
        public void ThenTheSystemThrowsTheErrorMessage(string loginErrorMessage)
        {
            if (loginPage.getTextLoginErrorMessage() == loginErrorMessage)
            {
                result = true;
            }
            Assert.IsTrue(result);
            result = false;
        }


        [Then(@"the system grant access by leaving the user on the Home Page in ""(.*)"" section")]
        public void ThenTheSystemGrantAccessByLeavingTheUserOnTheHomePageInSection(string tittleHomePage)
        {
            if (swagLabsHomePage.getTextProductsTittleHomePage() == tittleHomePage)
            {
                result = true;
            }
            Assert.IsTrue(result);
            result = false;
        }

        #endregion
    }
}
