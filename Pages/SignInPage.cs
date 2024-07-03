using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Luiz.Pages
{
    internal class SignInPage
    {
        public void SignInSteps(IWebDriver driver)
        {
            

            //Go to Home page
            driver.Navigate().GoToUrl("http://localhost:5000/");
            

            //Enter the credentials to SignIn

            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/a"));
            signinButton.Click();

            IWebElement emailBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailBox.SendKeys("luiz180@mail.com");

            IWebElement passBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passBox.SendKeys("Test123@");

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }
    }
}
