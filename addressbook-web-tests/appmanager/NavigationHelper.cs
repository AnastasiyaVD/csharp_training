using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }
        public void OpenHomePage()
        {
            if (driver.Url == baseURL)
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL);
        }
        public void GoToMainPage()
        {
            if (driver.Url == baseURL
                && IsElementPresent(By.LinkText("Last name")))
            {
                return;
            }
            driver.FindElement(By.LinkText("home")).Click();
        }

        public void GoToGroupPage()
        {
            if (driver.Url == baseURL + "group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void InitContactCreation()
        {
            if (driver.Url == baseURL + "edit.php"
                && driver.FindElement(By.TagName("h1")).Text
                == "Edit / add address book entry")
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
