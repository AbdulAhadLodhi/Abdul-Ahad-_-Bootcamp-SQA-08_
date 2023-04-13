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
    public class WE_and_Methods : Base_Class
    {
        By uname = By.XPath("//*[@id='email']");
        By pass = By.XPath("//*[@id='pass']");
        By logBtn = By.XPath("//*[@id='send2']/span");
        // validate login
        // string Text = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[1]/span")).Text;
        // string welcomeMessage = driver.FindElement(By.CssSelector(".welcome-msg > .hello > span")).Text;
        //Assert.AreEqual("Welcome, Usama Tahir!",Text);
        By Text = By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[1]/span");
       // By welcomeLocator = By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[1]/span");
        public void sendLoginDetails(string usrnm, string pswd)
        {
            findElement(uname);
            SendKeysMethod(uname, usrnm);
            findElement(pass);
            SendKeysMethod(pass, pswd);

            clickElement(logBtn);
            
           

        }
        public string expected()
        {

            IWebElement webElement = driver.FindElement(Text);
            string expected = webElement.GetAttribute("innerHTML").ToString();
            return expected;

        }

    }
}
