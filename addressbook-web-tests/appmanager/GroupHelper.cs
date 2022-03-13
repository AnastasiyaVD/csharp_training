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
    public class GroupHelper : HelperBase
    {
        
        public GroupHelper(ApplicationManager manager) //хелперу говорим о существовании менеджера
            : base(manager) // и в базовый класс передается ссылка на менеджер
        {
        }

        //это общий метод создания группы ->
        public GroupHelper Create(GroupData group)
        {
            manager.NavigationHelper.GoToGroupPage();//GroupHelper обращается к manager, чтобы получить доступ к NavigationHelper

            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            return this; //возвращает ссылку на тот же самый метод
        }
        public GroupHelper Remove(int p)
        {
            manager.NavigationHelper.GoToGroupPage();//GroupHelper обращается к manager, чтобы получить доступ к NavigationHelper

            SelectGroup(p);
            RemoveGroup();
            return this; //возвращает ссылку на тот же самый метод
        }

        public void Modify(int p, GroupData newData)
        {
            manager.NavigationHelper.GoToGroupPage();
            SelectGroup(p);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGropModification();
            ReturnToGroupPage();
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this; // когда мы вызываем в этом хелпере какой-то метод в результате возвращается ссылка на него же самого
        }
        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public void SelectGroup(int index)
        {
            if (! CheckedGpoupCreate(index))
            {
             CreateNewEmptyGroup();
            }

            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
        }

        public bool CheckedGpoupCreate(int index)
        {
            return IsElementPresent(By.XPath("//div[@id='content']/form/span[" + index + "]/input"));
        }

        public void CreateNewEmptyGroup()
        {
            driver.FindElement(By.Name("new")).Click();
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("group page")).Click();
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.XPath("//input[5]")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper SubmitGropModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        public List<GroupData> GetGroupList() // читаем элементы с web страницы, преобразовываем их в нужные объекты типа GroupData, а потом они будут сравниваться в тесте
        {
            List<GroupData> groups = new List<GroupData>();
            manager.NavigationHelper.GoToGroupPage(); //переход на нужную страницу
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
            foreach (IWebElement element in elements) // для каждого элемента в такой-то коллекции нужно выполнить такое-то действие
            {
                groups.Add(new GroupData(element.Text));// element.Text отправляется в качестве параметра в groups
            }
                
            return groups;
        }
    }
}
