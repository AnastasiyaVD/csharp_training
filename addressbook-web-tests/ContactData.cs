using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    public class ContactData
    {
        private string firstname = "";
        private string middlename = "";
        private string lastname = "";
        private string nickname = "";
        private string title = "";
        private string companyName = "";
        private string companyAddress = "";
        private string telephoneHome = "";
        private string telephoneMobile = "";
        private string telephoneWork = "";
        private string telephoneFax = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";
        private string birthdayDay = "";
        private string birthdayMonth = "";
        private string birthdayYear = "";
        private string anniversaryDay = "";
        private string anniversaryMonth = "";
        private string anniversaryYear = "";
        private string newGroup = "";
        private string homeAddress = "";
        private string houseNumber = "";
        private string notes = "";


        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Middlename
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }
        public string CompanyAddress
        {
            get
            {
                return companyAddress;
            }
            set
            {
                companyAddress = value;
            }
        }
        public string TelephoneHome
        {
            get
            {
                return telephoneHome;
            }
            set
            {
                telephoneHome = value;
            }
        }
        public string TelephoneMobile
        {
            get
            {
                return telephoneMobile;
            }
            set
            {
                telephoneMobile = value;
            }
        }
        public string TelephoneWork
        {
            get
            {
                return telephoneWork;
            }
            set
            {
                telephoneWork = value;
            }
        }
        public string TelephoneFax
        {
            get
            {
                return telephoneFax;
            }
            set
            {
                telephoneFax = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }
        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }
        }
        public string Homepage
        {
            get
            {
                return homepage;
            }
            set
            {
                homepage = value;
            }
        }
        public string BirthdayDay
        {
            get
            {
                return birthdayDay;
            }
            set
            {
                birthdayDay = value;
            }
        }
        public string BirthdayMonth
        {
            get
            {
                return birthdayMonth;
            }
            set
            {
                birthdayMonth = value;
            }
        }
        public string BirthdayYear
        {
            get
            {
                return birthdayYear;
            }
            set
            {
                birthdayYear = value;
            }
        }
        public string AnniversaryDay
        {
            get
            {
                return anniversaryDay;
            }
            set
            {
                anniversaryDay = value;
            }
        }
        public string AnniversaryMonth
        {
            get
            {
                return anniversaryMonth;
            }
            set
            {
                anniversaryMonth = value;
            }
        }
        public string AnniversaryYear
        {
            get
            {
                return anniversaryYear;
            }
            set
            {
                anniversaryYear = value;
            }
        }
        public string NewGroup
        {
            get
            {
                return newGroup;
            }
            set
            {
                newGroup = value;
            }
        }
        public string HomeAddress
        {
            get
            {
                return homeAddress;
            }
            set
            {
                homeAddress = value;
            }
        }
        public string HouseNumber
        {
            get
            {
                return houseNumber;
            }
            set
            {
                houseNumber = value;
            }
        }
        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }
    }
}
