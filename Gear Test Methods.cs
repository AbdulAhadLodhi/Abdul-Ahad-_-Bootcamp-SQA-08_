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


namespace Abdul_Ahad___Bootcamp_SQA_08.Gear
{

    [TestClass]
    public class Gear_Test_Methods : Base_Class
    {
        Gear_WE_and_Methods obj = new Gear_WE_and_Methods();
        
        [TestMethod]
        public void gear()
        {
            obj.gearDetails();



        }

    }
}
