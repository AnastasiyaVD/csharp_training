using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("new");
            newData.Middlename = "contact";
            newData.Lastname = "person";

            app.ContactHelper.Modify(2, 2, newData); //2 - это первый контакт (1-заголовок)
        }

        [Test]
        public void ContactModificationTestWithNullValue()
        {
            ContactData newData = new ContactData("Homerius");
            newData.Middlename = null;
            newData.Lastname = null;
            newData.Nickname = null;
            newData.Title = null;
            newData.CompanyName = null;
            newData.CompanyAddress = null;
            newData.TelephoneHome = null;
            newData.TelephoneMobile = null;
            newData.TelephoneWork = null;
            newData.TelephoneFax = null;
            newData.Email = "homerius@gmail.com";
            newData.Email2 = null;
            newData.Email3 = null;
            newData.Homepage = null;
            newData.BirthdayDay = null;
            newData.BirthdayMonth = null;
            newData.BirthdayYear = null;
            newData.AnniversaryDay = null;
            newData.AnniversaryMonth = null;
            newData.AnniversaryYear = null;
            newData.HomeAddress = null;
            newData.HouseNumber = null;
            newData.Notes = null;

            app.ContactHelper.Modify(3, 3, newData); //2 - это первый контакт (1-заголовок)
        }
    }
}
