using System;
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
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();
            // обращаемся к методу GetIstance, чтобы получить доступ к единственному
            // экземпляру который хранится внутри ApplicationManager, который автоматически
            // создается при первом обращении
        }
    }
}
