using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
       [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("group");
            group.Header = "group1";
            group.Footer = "small group";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.Create(group);//менеджер->Helper->тестовый метод

            List<GroupData> newGroups = app.GroupHelper.GetGroupList(); //возвращает список объектов типа GroupData
            
            Assert.AreEqual(oldGroups.Count +1, newGroups.Count);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.Create(group);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList(); //возвращает список объектов типа GroupData

            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }

        [Test]
        public void BadNameGroupCreationTest()
        {
            GroupData group = new GroupData("a'a");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.Create(group);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList(); //возвращает список объектов типа GroupData

            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }
    }
}

