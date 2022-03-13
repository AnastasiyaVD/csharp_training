using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Homer");
            contact.Middlename = "Jay";
            contact.Lastname = "Simpson";
            contact.Nickname = "Kidneys";           
            contact.Title = "empty";
            contact.CompanyName = "nuciear power station";
            contact.CompanyAddress = "Springfield";
            contact.TelephoneHome = "1111111111";
            contact.TelephoneMobile = "2222222222";
            contact.TelephoneWork = "3333333333";
            contact.TelephoneFax = "4444444444";
            contact.Email = "homer@gmail.com";
            contact.Email2 = "simpson@gmail.com";
            contact.Email3 = "kidneys@gmail.com";
            contact.Homepage = "www.simpson.com";
            contact.BirthdayDay = "10";
            contact.BirthdayMonth = "May";
            contact.BirthdayYear = "1959";
            contact.AnniversaryDay = "10";
            contact.AnniversaryMonth = "May";
            contact.AnniversaryYear = "2059";
            contact.HomeAddress = "Springfield, Evergreen terrace";
            contact.HouseNumber = "742";
            contact.Notes = "empty";
            app.ContactHelper.Create(contact);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
             ContactData contact = new ContactData("Elon");
            contact.Middlename = "Reeve";
            contact.Lastname = "Musk";
            app.ContactHelper.Create(contact);
        }
    }
}

