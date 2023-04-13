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


namespace Abdul_Ahad___Bootcamp_SQA_08.Review
{
    [TestClass]
    public class Review_Test_Methods:Base_Class
    {
       
          Review_WE_and_Methods obj = new Review_WE_and_Methods();

        [TestMethod]
        public void Review()
        {
            obj.ReviewDetails("Selene Yoga Hoodie", "good ho gya", "done");
        }

    }
}
