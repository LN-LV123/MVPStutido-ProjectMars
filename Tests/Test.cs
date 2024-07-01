using Mars_Luiz.Pages;
using Mars_Luiz.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.Storage;
using OpenQA.Selenium.Support.UI;

namespace Mars_Luiz.Tests

{
    [TestFixture]
    internal class Mars : CommonDriver
    {
        [SetUp]
        public void SignSignInSteps()
        {
            //Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void AddLanguage()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            //Language page object initialization and definition
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.Addlanguage(driver);
        }

        [Test]
        public void AddFourLanguages()
        {
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            ProfilePage homePageObj = new ProfilePage();
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.AddFourLanguages(driver);

        }

        [Test]
        public void EditLanguage()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.Editlanguage(driver);
        }

        [Test]
        public void DeleteLanguage()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            LanguagePage profilePageObj = new LanguagePage();
            profilePageObj.Deletelanguange(driver);

        }
        [TearDown]
        public void CloseLanguageTest()
        {

        }


        [Test]

        public void AddSkills()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            //Skills page Object initialization an definition
            SkillsPage skillsTabPageObj = new SkillsPage();
            skillsTabPageObj.SkillsPageTab(driver);
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.AddSkills(driver);
        }

        [Test]

        public void AddSameSkills()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            //Skills page Object initialization an definition
            SkillsPage skillsTabPageObj = new SkillsPage();
            skillsTabPageObj.SkillsPageTab(driver);
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.AddSameSkills(driver);
        }

        [Test]

        public void AddCharactersSpecSkills()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            //Skills page Object initialization an definition
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.AddSpecialCharactSkills(driver);
        }


        [Test]
        public void EditSkills()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            //Edit Skills
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.EditSkills(driver);

        }

        [Test]
        public void DeleteSkills()
        {
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
            //Profile page object initialization and definition
            ProfilePage homePageObj = new ProfilePage();
            homePageObj.GoToProfilePage(driver);
            //Delete Skills
            //skillsPageObj.DeleteSkills(driver)

        }
        [TearDown]
        public void CloseSkillsTest()
        {

        }

        
       




    }
}

        




















