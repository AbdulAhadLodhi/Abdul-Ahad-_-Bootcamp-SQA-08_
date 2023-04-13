using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Edge;
using static System.Net.Mime.MediaTypeNames;

namespace Abdul_Ahad___Bootcamp_SQA_08.Sign_In
{
    [TestClass]
    public class Login_TM
    {
        WE_and_Methods obj = new WE_and_Methods();

        [TestMethod]
        public void LoginWithValidCredentials()
        {
            Base_Class.SetDriver("Chrome");

            obj.sendLoginDetails("usamatahir693@gmail.com", "Usama@4489");

            Console.Write(obj.expected());
            Assert.AreEqual("Welcome, Usama Tahir!", obj.expected());
        }

        

    }
}
