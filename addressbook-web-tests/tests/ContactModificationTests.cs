using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("new");
            newData.Middlename = "contact";
            newData.Lastname = "person";

            app.ContactHelper.Modify(2, 2, newData); //2 - это первый контакт (1-заголовок)
        }
    }
}
