using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.Remove(1);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList(); //возвращает список объектов типа GroupData

            if (oldGroups.Count == 0)
            {
                Assert.AreEqual(oldGroups.Count, newGroups.Count);
            }
            else
            {
                Assert.AreEqual(oldGroups.Count , newGroups.Count - 1);
            }
        }                    
    }
}
