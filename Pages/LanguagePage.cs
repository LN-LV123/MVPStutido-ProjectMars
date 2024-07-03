using Mars_Luiz.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.CacheStorage;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Mars_Luiz.Pages
{
    internal class LanguagePage
    {
        public void Addlanguage(IWebDriver driver)
        {
            //Add Language           
            
            
            IWebElement addnewButton = driver.FindElement(By.CssSelector(".ui:nth-child(2) > .row .ui .ui"));
            addnewButton.Click();

            IWebElement languangeTextbox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languangeTextbox.Click();
            driver.FindElement(By.Name("name")).SendKeys("Portuguese");

            IWebElement selectLevel = driver.FindElement(By.Name("level"));
            selectLevel.Click();

            {
                var dropdown = driver.FindElement(By.Name("level"));
                dropdown.FindElement(By.XPath("//option[. = 'Native/Bilingual']")).Click();
            }

            IWebElement addButton = driver.FindElement(By.CssSelector(".six > .teal"));
            addButton.Click();

        }

        public void AddFourLanguages(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement addnewButton = driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            IWebElement languageTextBox = driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div/input"));
            languageTextBox.Click();
            driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div/input")).SendKeys("English");

            IWebElement selectLevel = driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            selectLevel.Click();

            {
                var dropdown = driver.FindElement(By.Name("level"));
                dropdown.FindElement(By.XPath("//option[. = 'Conversational']")).Click();
            }

            IWebElement addButton = driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input"));
            addButton.Click();

            Thread.Sleep(2000);
            addnewButton.Click();
            driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div/input")).SendKeys("Portuguese");
            
            {
                var dropdown = driver.FindElement(By.Name("level"));
                dropdown.FindElement(By.XPath("//option[. = 'Native/Bilingual']")).Click();
            }

            driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

            Thread.Sleep(2000);
            addnewButton.Click();
            driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div/input")).SendKeys("Spanish");

            {
                var dropdown = driver.FindElement(By.Name("level"));
                dropdown.FindElement(By.XPath("//option[. = 'Basic']")).Click();
            }

            driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

            Thread.Sleep(1000);
            addnewButton.Click();
            driver.FindElement(By.XPath("//div[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div/input")).SendKeys("Italian");

            {
                var dropdown = driver.FindElement(By.Name("level"));
                dropdown.FindElement(By.XPath("//option[. = 'Basic']")).Click();
            }

            driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();


            

        }

               
        public string GetLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement addedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return addedLanguage.Text;           
            
        }
        public string GetChooseLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement choseLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return choseLevel.Text;
        }

        //Edit Language
        public void Editlanguage(IWebDriver driver)
        {
            IWebElement dashboardTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[1]"));
            dashboardTab.Click();
            Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[1]/div/a[1]", 2);

            IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\'notification-section\']/section[1]/div/a[2]"));
            profileTab.Click();
            Wait.WaitToBeClickable(driver, "xPath", "//*[@id='notification - section']/section[1]/div/a[2]", 3);

            IWebElement editPencil = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editPencil.Click();

            IWebElement languageTextBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            languageTextBox.Clear();
            languageTextBox.SendKeys("Spanish");

            IWebElement dropdowBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            dropdowBox.Click();
            IWebElement selectlevelBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            selectlevelBox.SendKeys("Basic");
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();
            //Wait.WaitToBeClickable(driver, "xPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 2);

        }
        public string GetEditedLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedLanguage = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return editedLanguage.Text;


        }

        //Delete Language
        public void Deletelanguange(IWebDriver driver)
        {
            //IWebElement dashboardTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[1]"));
            //dashboardTab.Click();
            //Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\'account-profile-section\']/div/section[1]/div/a[1]", 2);

            //IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\'notification-section\']/section[1]/div/a[2]"));
            //profileTab.Click();
            //Wait.WaitToBeClickable(driver, "xPath", "//*[@id='notification - section']/section[1]/div/a[2]", 3);

            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteIcon.Click();

        }
       
       

               

    }

    
}
