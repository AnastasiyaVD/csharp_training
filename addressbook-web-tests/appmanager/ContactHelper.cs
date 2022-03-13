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
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public ContactHelper Remove(int r)
        {
            manager.NavigationHelper.GoToMainPage();//GroupHelper обращается к manager, чтобы получить доступ к NavigationHelper

            SelectContact(r);
            RemoveContact();
            CloseDialogWindow();
            return this;
        }

        public ContactHelper Modify(int v, int p, ContactData newData)
        {
            manager.NavigationHelper.GoToMainPage();
            SelectContact(v);
            InitContactModification(p);
            AddContactData(newData);
            SubmitContactModification();
            ReturnToHomePage();
            return this;
        }

        

        //это общий метод создания контакта ->
        public ContactHelper Create(ContactData contact)
        {
            manager.NavigationHelper.InitContactCreation();
            AddContactData(contact);
            SubmitContactCreation();
            ReturnToHomePage();
            return this; //возвращает ссылку на тот же самый метод
        }
        public ContactHelper AddContactData(ContactData contact)
        {
            //AddContactData
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), contact.Nickname);

            //AddInfoCompany
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.CompanyName);
            Type(By.Name("address"), contact.CompanyAddress);

            //ContactDetails
            Type(By.Name("home"), contact.TelephoneHome);
            Type(By.Name("mobile"), contact.TelephoneMobile);
            Type(By.Name("work"), contact.TelephoneWork);
            Type(By.Name("fax"), contact.TelephoneFax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.Homepage);

            //AddBirthday
            OpenDropDownList(By.Name("bday"), contact.BirthdayDay);
            OpenDropDownList(By.Name("bmonth"), contact.BirthdayMonth);
            Type(By.Name("byear"), contact.BirthdayYear);

            //AddAnniversary
            OpenDropDownList(By.Name("aday"), contact.AnniversaryDay);
            OpenDropDownList(By.Name("amonth"), contact.AnniversaryMonth);
            Type(By.Name("ayear"), contact.AnniversaryYear);

            //AddHomeAddress

            Type(By.Name("address2"), contact.HomeAddress);
            Type(By.Name("phone2"), contact.HouseNumber);

            //AddNotes
            Type(By.Name("notes"), contact.Notes);
            
            return this;
        }

        public void SelectContact(int index)
        {
            if (!CheckedContactCreate(index))
            {
                for (int i = 1; i <= index-1; i++) //(index-1) тк первый пункт в списке контактов имеет индекс 2
                {
                    CreateNewEmptyContact();
                }

            }

            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[" + index + "]/td/input")).Click();
           
        }

        
        public bool CheckedContactCreate(int index)
        {
            return IsElementPresent(By.XPath("//div[@id='content']/form/span[" + index + "]/input"));
        }

        public void CreateNewEmptyContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("home page")).Click();
        }

        public ContactHelper InitContactModification(int p)
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[" + p + "]/td[8]/a/img")).Click();
            return this;
        }
        
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }
        public ContactHelper CloseDialogWindow()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
