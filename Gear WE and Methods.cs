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
    public class Gear_WE_and_Methods : Base_Class
    {
        By gear = By.XPath("/html/body/div[1]/div/div/div[2]/nav/ul/li[4]");
        By fitnessEquipment = By.XPath("/html/body/div[1]/main/div[4]/div[2]/div[1]/div[2]/dl/dd/ol/li[2]/a");
        By firstItem = By.XPath("/html/body/div[1]/main/div[3]/div[1]/div[3]/ol/li[1]/div/a/span/span/img");
        By wishList = By.XPath("/html/body/div[1]/main/div[2]/div/div[1]/div[5]/div/a[1]/span");
        By mangAcnt = By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[2]/span/button");
        By myWishList = By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[2]/div/ul/li[2]");

        public void gearDetails()
        {
            Base_Class.SetDriver("Chrome");
            Thread.Sleep(1000);
            clickElement(gear);
            clickElement(fitnessEquipment);
            clickElement(firstItem);
            clickElement(wishList);
            clickElement(mangAcnt);
            clickElement(myWishList);



        }

    }
}
