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

namespace Abdul_Ahad___Bootcamp_SQA_08.whatsnew
{
    public class whatsnew_WE_and_Methods : Base_Class
    {

        By whatsnew = By.XPath("/html/body/div[1]/div/div/div[2]/nav/ul/li[1]/a/span");
        By jackets = By.XPath("//*[@id='maincontent']/div[4]/div[2]/div/div/ul[1]/li[2]/a");
        By size = By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div/div[2]/div[1]");
        By XL = By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div/div[2]/div[2]/div/div/a[5]/div");
        By price = By.XPath("/ html / body / div[1] / main / div[3] / div[2] / div / div[2] / div[3] / div[2] / div[1]");
        By dollars = By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div[3]/div[2]/div[2]/ol/li[3]/a");
        By colour = By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div[3]/div[2]/div[1]");
        By black = By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div[3]/div[2]/div[2]/div/div/a[1]/div");
        

        public void WhatsNewDetails()
        {
           // Base_Class.SetDriver("Chrome");
            Thread.Sleep(1000);
            clickElement(whatsnew);
            clickElement(jackets);
            clickElement(size);
            clickElement(XL);
            clickElement(price);
            clickElement(dollars);
            clickElement(colour);
            clickElement(black);
            

        }
    }    
}
