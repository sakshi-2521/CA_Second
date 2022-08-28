using CA_Second.CommonMethodObjects;
using System;
using TechTalk.SpecFlow;

namespace CA_Second
{
    [Binding]
    public class Feature1StepDefinitions
    {
        ObjectClass obj = new ObjectClass();
        [Given(@"User is on home page")]
        public void GivenUserIsOnHomePage()
        {
            obj.VerifyHomePage();
        }

        [When(@"User Click on Register")]
        public void WhenUserClickOnRegister()
        {
            obj.UserRegister();
        }

        [Then(@"User is on SignUp page")]
        public void ThenUserIsOnSignUpPage()
        {
            obj.SignUpPage();
        }

        [When(@"User click on signup")]
        public void WhenUserClickOnSignup()
        {
            obj.UserSignUp();
        }

        [When(@"User enters name")]
        public void WhenUserEntersName()
        {
            obj.UserName();
        }

        [When(@"User enters emailId")]
        public void WhenUserEntersEmailId()
        {
            obj.EmailID();
        }

        [When(@"User enters password")]
        public void WhenUserEntersPassword()
        {
            obj.Password();
        }

        [When(@"User click on Create account")]
        public void WhenUserClickOnCreateAccount()
        {
            obj.CreateAccount();
            
        }

        [When(@"User click on submit")]
        public void WhenUserClickOnSubmit()
        {
           // obj.
        }

        [When(@"User click on Get Cupons")]
        public void WhenUserClickOnGetCupons()
        {
            
        }

        [When(@"User click on get started")]
        public void WhenUserClickOnGetStarted()
        {
            
        }

        [When(@"User click on Complete profile")]
        public void WhenUserClickOnCompleteProfile()
        {
            
        }

        [Then(@"User can see earn bonus point page")]
        public void ThenUserCanSeeEarnBonusPointPage()
        {
            
        }
    }
}
