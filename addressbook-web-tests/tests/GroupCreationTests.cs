using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("group");
            group.Header = "group1";
            group.Footer = "small group";
            app.GroupHelper.Create(group);//менеджер->Helper->тестовый метод
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            app.GroupHelper.Create(group);
        }
    }
}

