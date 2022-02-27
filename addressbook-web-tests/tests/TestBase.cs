﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    public class TestBase
    {
        protected ApplicationManager app;
        

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager(); //инициализация ApplicationManager
            app.NavigationHelper.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Auth.Logout();
            app.Stop(); 
        }        
    }
}