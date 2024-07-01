using Mars_Luiz.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Mars_Luiz.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Framework.Legacy;

namespace Mars_Luiz.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions :CommonDriver
    {
        [Given(@"I logged into the portal successfull")]
        public void GivenILoggedIntoThePortalSuccessfull()
        {
            //Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);            
        }

        [When(@"I navigate to Profile page")]
        public void WhenINavigateToProfilePage()
        {
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
        }

     // Add Language

        [When(@"I add the Language in the Language section")]
        public void WhenIaddTheLanguageToLanguangePage()
        {
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.Addlanguage(driver);
        }

        [Then(@"The languange shoould be added successfully")]
        public void ThenTheLanguangeShoouldBeAddedSuccessfully()
        {
            LanguagePage profilePageObj = new LanguagePage();
            string addedLanguage = profilePageObj.GetLanguage(driver);
            Assert.That(addedLanguage == "Portuguese", "Currently added language does not match");
        }

        //Add more than four Languages

        [When(@"I add more than four Languages in the Language section")]
        public void WhenIAddMoreThanFourLanguagesInTheLanguageSection()
        {
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.AddFourLanguages(driver);
        }

        [Then(@"Languanges shoould be added successfully but not more than four")]
        public void ThenLanguangesShoouldBeAddedSuccessfullyButNotMoreThanFour()
        {
            throw new PendingStepException();
        }


        //Edit Language

        [When(@"I edit Language and levles in the Language section")]
        public void WhenIEditLanguageAndLevlesInTheLanguageSection()
        {
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.Editlanguage(driver);
        }

        [Then(@"The languanges shoould be edited successfully")]
        public void ThenTheLanguangesShoouldBeEditedSuccessfully()
        {
            LanguagePage profilePageObj = new LanguagePage();
            string editLanguage = profilePageObj.GetEditedLanguage(driver);
            Assert.That(editLanguage == "Spanish", "Currently edited language does not match");

        }

     //Delete Language

        [When(@"I delete the Language in the Language section")]
        public void WhenIDeleteTheLanguageInTheLanguageSection()
        {
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.Deletelanguange(driver);
        }

        [Then(@"The languange shoould be deleted successfully")]
        public void ThenTheLanguangeShoouldBeDeletedSuccessfully()
        {
            LanguagePage profilePageObj = new LanguagePage();
            var elements = driver.FindElements(By.XPath("/html/body/div[1]/div"));
            ClassicAssert.True(elements.Count > 0);
        }

    }

}
