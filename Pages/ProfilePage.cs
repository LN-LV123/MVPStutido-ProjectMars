using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Luiz.Utilities;

namespace Mars_Luiz.Pages
{
    internal class ProfilePage
    {
        public void GoToProfilePage(IWebDriver driver)

        {
            //Go to Profile

            Wait.WaitToBeVisable(driver, "XPath", "//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]", 2);
            IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]"));
            profileTab.Click();
            
           
        }

    }
}
