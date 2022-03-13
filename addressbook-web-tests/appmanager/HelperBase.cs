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
   public class HelperBase
   {
        protected IWebDriver driver;
        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager; //чтобы каждый помощник знал про своего менеджера
            driver = manager.Driver; //получает ссылку на драйвер у менеджера
        }

        public void Type(By locator, string text)
        {
            if (text != null) //здесь else не нужен
            {
                driver.FindElement(locator).Click();
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            //if (text == null) //если текст = null, тогда ничего не делать
            //{
            //}
            //else //иначе
            //{
            //    driver.FindElement(locator).Click();
            //    driver.FindElement(locator).Clear();
            //    driver.FindElement(locator).SendKeys(text);
            //}

        }
        public void OpenDropDownList(By locator, string text)
        {
            if (text != null) //здесь else не нужен
            {
                driver.FindElement(locator).Click();
                new SelectElement(driver.FindElement(locator)).SelectByText(text);
            }
        }
        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
   }

}