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
    public class Review_WE_and_Methods:Base_Class
    {
        By search = By.XPath("/html/body/div[1]/header/div[2]/div[2]/div[2]/form/div[1]/div/input");
        By firstItem =By.XPath("/html/body/div[1]/main/div[3]/div[1]/div[2]/div[2]/ol/li[1]/div/a/span/span/img");
        By addReview = By.XPath("/html/body/div[1]/main/div[2]/div/div[1]/div[2]/div[2]/a[2]");
        By ratting = By.XPath("/html/body/div[1]/main/div[2]/div/div[3]/div/div[6]/div[2]/div[2]/form/fieldset/fieldset/div/div/div/div/label[1]");
        By nickName = By.XPath("/html/body/div[1]/main/div[2]/div/div[3]/div/div[6]/div[2]/div[2]/form/fieldset/div[1]/div/input");
        By summary = By.XPath("/html/body/div[1]/main/div[2]/div/div[3]/div/div[6]/div[2]/div[2]/form/fieldset/div[2]/div/input");
        By review = By.XPath("/html/body/div[1]/main/div[2]/div/div[3]/div/div[6]/div[2]/div[2]/form/fieldset/div[3]/div/textarea");
        By submitBtn = By.XPath("/html/body/div[1]/main/div[2]/div/div[3]/div/div[6]/div[2]/div[2]/form/div/div/button/span");
        public void ReviewDetails(string Search, string Summary, string Review)  
        {
            findElement(search);
            SendKeysMethod(search,"Selene Yoga Hoodie");
            findElement(firstItem);
            findElement(addReview);
            findElement(ratting);
            findElement(nickName);
            findElement(summary);
            SendKeysMethod(summary, "good ho gya");
            findElement(review);
            SendKeysMethod(review, "done");
            findElement(submitBtn);


        }

       
    }
}
