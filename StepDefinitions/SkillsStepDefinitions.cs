using Mars_Luiz.Pages;
using Mars_Luiz.Utilities;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace Mars_Luiz.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : CommonDriver
    {
        //Add Skills
        [Given(@"I log into the Portal successfull")]

        public void GivenILoggedIntoThePortalSuccessfull()
        {
            //Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Sign IN page object initialization and definition
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInSteps(driver);
        }


        [When(@"I navigate to Skills page")]
        public void WhenINavigateToSkillsPage()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.SkillsPageTab(driver);
        }

        [When(@"I add the Skill and Skill level")]
        public void WhenIAddTheSkillAndSkillLevel()
        {
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.AddSkills(driver);
        }


        [Then(@"The skill and skills level should be added successfull")]
        public void ThenTheSkillAndSkillsLevelShouldBeAddedSuccessfull()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string addedSkill = skillsPageObj.GetSkills(driver);
            string addedSkillLevel = skillsPageObj.GetSkillsLevel(driver);
            Assert.That(addedSkill == "Azure", " Skill has not benn successfull added");
            Assert.That(addedSkillLevel == "Expert", "Skill Level has not successful added");
            
        }

        //Edit Skills

        [When(@"I edit the skills and skill level")]
        public void WhenIEditTheSkillsAndSkillLevel()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.EditSkills(driver);
        }

        [Then(@"The skill and skills level should be edited successfull")]
        public void ThenTheSkillAndSkillsLevelShouldBeEditedSuccessfull()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string editedSkill = skillsPageObj.GetEditedSkill(driver);
            string editedSkillLevel = skillsPageObj.GetEditedSkillLevel(driver);
            Assert.That(editedSkill == "Windows2019", "Skill has not been successfull edited");
            Assert.That(editedSkillLevel == "Intermediate", "Skill has not been successfull changed");
        }


       //Delete Skill
               
        [When(@"I delete the skills")]
        public void WhenIDeleteTheSkills()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.DeleteSkills(driver);
        }

        [Then(@"The skill and skills level should be deleted successfull")]
        public void ThenTheSkillAndSkillsLevelShouldBeDeletedSuccessfull()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            var elements = driver.FindElements(By.XPath("/html/body/div[1]/div"));
            ClassicAssert.True(elements.Count > 0);
            
        }

        //Add Special and long Characters

        [When(@"I add Special Characters and long leangh skills")]
        public void WhenIAddSpecialCharactersAndLongLeanghSkills()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.AddSpecialCharactSkills(driver);

        }

        [Then(@"Should not be added successfull")]
        public void ThenShouldNotBeAddedSuccessfull()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string specialCharcSkill = skillsPageObj.SpecialCharcSkills(driver);
            if (specialCharcSkill.Contains("%%%^^^&&**(())!!@g.com.au###########@@@@@@@@@@@@@@@@@@@%%%^^^&&**(())!!@g.com.au###########@@@@@@@@@@@@@@@@@@@"))
            {
                Assert.Pass("This type of skill should have not been added");
            }
            else
            {
                Assert.Fail("Skill successfull not added");
            }
               
        }

        //Add same Skills


        [When(@"I add same skills")]
        public void WhenIAddSameSkills()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.AddSameSkills(driver);
        }

        [Then(@"Same skills should not be add sucessfull")]
        public void ThenSameSkillsShouldNotBeAddSucessfull()
        {
            SkillsPage skillsPageObj = new SkillsPage();            
            string duplicatedData = skillsPageObj.SameSkills(driver);
            if (duplicatedData.Contains("Duplicated data"))
            {
                Assert.Pass("This skill is already added");
            }
            else
            {
                Assert.Fail("This is skill should not be added");
            }

        }

    }
}
