using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.Events;

namespace CA_Second.Utilities
{
    [Binding]
     public static class BaseClass
    {
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static IWebDriver driver;
        [BeforeFeature]
        public static void FeatureBrowser(FeatureContext featureContext)
        {
            feature = extents.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }
        [BeforeScenario]
        public static void LaunchBrowser(ScenarioContext scenarioContext)
        {
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tide.com/en-us");
            driver.Manage().Window.Maximize();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("One.png", ScreenshotImageFormat.Png);
        }
        [BeforeTestRun]
        public static void GenereateReport()
        {
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\nandi\source\repos\CA_Second\CA_Second\index.html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
        }
        [AfterTestRun]
        public static void CloseExtentReport()
        {
            extents.Flush();
        }
        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

                if (stepType == "When")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "And")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

            }

            if (scenarioContext.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);

                if (stepType == "When")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);

            }

        }
        [AfterScenario]
        public static void Cleanup()
        {
            driver.Quit();
        }
    }
}
