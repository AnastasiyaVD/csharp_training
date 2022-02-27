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
    public class ApplicationManager //управляет тестируемым приложением
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        public ApplicationManager() 
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost/addressbook/";
            

            loginHelper = new LoginHelper(this); //делаем ссылку на ApplicationManager
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public IWebDriver Driver 
        {
            get 
            {
                return driver;
            } 
                
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        //делаем доступ к помошникам (Helper) при помощи создания свойста с get-тером
        public LoginHelper Auth //authentication
        {
        get 
            {
                return loginHelper; 
            }
        }
        public NavigationHelper NavigationHelper
        {
            get 
            {
                return navigationHelper; 
            }
        }
        public GroupHelper GroupHelper
        {
            get 
            {
                return groupHelper; 
            }
        }
        public ContactHelper ContactHelper
        {
            get 
            {
                return contactHelper; 
            }
        }
        
    }
}
