using Mars_Luiz.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.CacheStorage;
using OpenQA.Selenium.DevTools.V123.Overlay;
using OpenQA.Selenium.DevTools.V123.Runtime;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Mars_Luiz.Pages
{
    internal class SkillsPage
    {
        public void SkillsPageTab(IWebDriver driver)
        {

            //Wait.WaitToBeVisable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);
            Thread.Sleep(2000);
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();            

        }

        //Add Skills
        public void AddSkills(IWebDriver driver)
        {          

            
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 2);

            IWebElement skillBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillBox.SendKeys("Azure");

            IWebElement choosedropdownBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            choosedropdownBox.SendKeys("Expert");
            IWebElement addskillButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addskillButton.Click();

        }

        //Add Skills with special radom Characthers 
        public void AddSpecialCharactSkills(IWebDriver driver)
        {
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
            Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);

            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 2);

            IWebElement skillBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillBox.SendKeys("%%%^^^&&**(())!!@g.com.au###########@@@@@@@@@@@@@@@@@@@%%%^^^&&**(())!!@g.com.au###########@@@@@@@@@@@@@@@@@@@");

            IWebElement choosedropdownBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            choosedropdownBox.SendKeys("Expert");
            IWebElement addskillButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addskillButton.Click();
        }

        //Add existing Skills

        public void AddSameSkills(IWebDriver driver)
        {            

            
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            
            IWebElement skillBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillBox.SendKeys("Azure");            

            IWebElement choosedropdownBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            choosedropdownBox.SendKeys("Beginner");

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();           
            
           
        }

       
        //Edit Skills
        public void EditSkills(IWebDriver driver)
        {
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
            Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);

            IWebElement editSkillsPencil = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editSkillsPencil.Click();
            IWebElement skillBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillBox.Clear();
            skillBox.SendKeys("Windows2019");


            IWebElement choosedropdownBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select"));
            choosedropdownBox.Click();          
            
            choosedropdownBox.SendKeys("Intermediate");



            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();

        }

        //Delete Skills
        public void DeleteSkills(IWebDriver driver)
        {
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
            Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);

            IWebElement deletePencilButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deletePencilButton.Click();

        }

        //String for Add Skills
        public string GetSkills(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement addedSkill = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return addedSkill.Text;
        }

        public string GetSkillsLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement addedSkillLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return addedSkillLevel.Text;
        }


        //String for Edit Skills
        public string GetEditedSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedSkill = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return editedSkill.Text;            
        }

        public string GetEditedSkillLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedSkillLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editedSkillLevel.Text;
        }

        //String for Same Skill
        public string SameSkills(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement duplicateData = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return duplicateData.Text;

        }

        //String for Special long Characters
        public string SpecialCharcSkills(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement specialcharcSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
            return specialcharcSkills.Text;
        }









    }
}
