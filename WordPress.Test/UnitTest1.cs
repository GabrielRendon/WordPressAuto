using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;
using WordPress.Framework.Pages;

namespace WordPress.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            BrowserManager.Instance.Init();
        }

        [TestMethod]
        public void User_Can_Login()
        {
            //Test Steps
            LoginPage.GoTo();
            LoginPage.LoginAs("Gonzalo")
                     .WithPassword("Control123!")
                     .Login();

            //Validation
            Assert.IsTrue(DashboardPage.IsAt);
        }

        [TestCleanup]
        public void Clean()
        {
            BrowserManager.Instance.Close();
        }
    }
}
