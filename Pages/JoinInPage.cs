using Mars_Luiz.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Luiz.Pages
{
    internal class JoinInPage
    {
        public void JoinIN(IWebDriver driver)
        {

            //Go to Home page
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //Click in Join the App
            
            IWebElement joinButton = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/button"));
            joinButton.Click();

            //Enter the details to join the page
            IWebElement firstnameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
            firstnameTextbox.SendKeys("Luiz");
            IWebElement lastnameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
            lastnameTextbox.SendKeys("Foo");
            IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
            emailTextbox.SendKeys("luiz290@mail.com");
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
            passwordTextbox.SendKeys("Test123@");
            IWebElement confirmpasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
            confirmpasswordTextbox.SendKeys("Test123@");
            IWebElement acceptBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
            acceptBox.Click();
            IWebElement join1button = driver.FindElement(By.XPath("//*[@id=\'submit-btn\']"));
            join1button.Click();

        }

        public void JoinINMissInfo(IWebDriver driver)
        {
            //Enter same email information to join the page

            //Go to Home page
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //Click in Join the App

            IWebElement joinButton = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/button"));
            joinButton.Click();

            //Enter the details to join the page
            IWebElement firstnameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
            firstnameTextbox.SendKeys("Luiz");
            IWebElement lastnameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
            lastnameTextbox.SendKeys("Foo");
            IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
            emailTextbox.SendKeys("luiz290@mail.com");
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
            passwordTextbox.SendKeys("Test123@");
            IWebElement confirmpasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
            confirmpasswordTextbox.SendKeys("Test123@");
            IWebElement acceptBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
            acceptBox.Click();
            IWebElement join1button = driver.FindElement(By.XPath("//*[@id=\'submit-btn\']"));
            join1button.Click();


        }


    }
}
