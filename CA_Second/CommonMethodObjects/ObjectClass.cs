using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_Second.Utilities;
using OpenQA.Selenium.DevTools.V102.Emulation;

namespace CA_Second.CommonMethodObjects
{
    public class ObjectClass
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void VerifyHomePage()
        {
            IWebElement home;
            bool display = true;
            home = BaseClass.driver.FindElement(By.XPath("//span[.='Part of the P&G Family']"));
            log.Info("SuccessfullyVerified");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("two.png", ScreenshotImageFormat.Png);
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            display = home.Displayed;
        }
        public void UserRegister()
        {
            IWebElement userRegister = BaseClass.driver.FindElement(By.XPath("//*[@id=\"site-header\"]/div[1]/div/div/div/div[2]/span/a"));
            userRegister.Click();
            log.Info("SuccessfullyVerified");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("three.png", ScreenshotImageFormat.Png);

        }
        public void SignUpPage()
        {
            IWebElement signUpPage;
            bool display = true;
            signUpPage = BaseClass.driver.FindElement(By.XPath("//a[.='Sign up now']"));
            display = signUpPage.Displayed;
            log.Info("SuccessfullyVerified");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("four.png", ScreenshotImageFormat.Png);
        }
        public void UserSignUp()
        {
            IWebElement userSignUp = BaseClass.driver.FindElement(By.XPath("//*[@id=\"site-content\"]/div/div/div/div/div[1]/div/div/div/div[2]/div/p[6]/a"));
            userSignUp.Click();
            log.Info("SuccessfullyVerified");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("five.png", ScreenshotImageFormat.Png);
        }
        public void UserName()
        {
            IWebElement name = BaseClass.driver.FindElement(By.XPath("//*[@id=\"name\"]"));
            name.SendKeys("Sakshi Tiwari");
            log.Info("SuccessfullyVerified");

        }
        public void EmailID()
        {
            IWebElement email = BaseClass.driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("sakshitiwari081999@gmail.com");
            log.Info("SuccessfullyVerified");
        }
        public void Password()
        {

            IWebElement psswd = BaseClass.driver.FindElement(By.XPath("//input[@id='password']"));
            psswd.SendKeys("Rama@12345");
            log.Info("SuccessfullyVerified");
        }
        public void CreateAccount()
        {
            IWebElement CrtAcnt = BaseClass.driver.FindElement(By.XPath("//input[@id='scroll']"));
            CrtAcnt.Click();
            log.Info("SuccessfullyVerified");

        }
        public void Submit()
        {
            IWebElement submit = BaseClass.driver.FindElement(By.XPath("//div[.='SUBMIT']"));
            submit.Click();
            log.Info("SuccessfullyVerified");
        }
        public void GetCupons()
        {
            IWebElement cupons = BaseClass.driver.FindElement(By.XPath("//a[.='GET CUPONS']"));
            cupons.Click();
            log.Info("SuccessfullyVerified");
        }
        
    }
}
