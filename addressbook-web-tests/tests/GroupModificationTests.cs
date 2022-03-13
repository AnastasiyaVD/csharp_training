using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    { 
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "ttt";
            newData.Footer = "qqq";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.Modify(1, newData);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList(); //возвращает список объектов типа GroupData

            if (oldGroups.Count == 0)
            {
                Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
            }
            else
            {
                Assert.AreEqual(oldGroups.Count, newGroups.Count);
            }
        }

        [Test]
        public void GroupModificationTestWithNullValue()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;
            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.Modify(1, newData);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList(); //возвращает список объектов типа GroupData

            if (oldGroups.Count == 0)
            {
                Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
            }
            else
            {
                Assert.AreEqual(oldGroups.Count, newGroups.Count);
            }
        }
    }
}
