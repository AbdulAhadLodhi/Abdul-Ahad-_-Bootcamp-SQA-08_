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

namespace Abdul_Ahad___Bootcamp_SQA_08.whatsnew
{
    [TestClass]
    public class whatsnew_Test_Methods
    {
      whatsnew_WE_and_Methods obj = new whatsnew_WE_and_Methods();

        [TestMethod]
        public void Whatsnew()
        {

            obj.WhatsNewDetails();
        }

    }
}
