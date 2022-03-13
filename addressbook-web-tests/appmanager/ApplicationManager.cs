using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>(); // для многопоточности
        
        private ApplicationManager() 
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost/addressbook/";
            

            loginHelper = new LoginHelper(this); //делаем ссылку на ApplicationManager
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        ~ApplicationManager() //название деструктора (тильда и название класса)
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

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated) 
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.NavigationHelper.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver 
        {
            get 
            {
                return driver;
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
