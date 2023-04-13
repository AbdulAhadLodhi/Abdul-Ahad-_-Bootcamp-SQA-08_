using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Edge;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
         //public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
         //Login with Valid username and password. Validate user should successfully login.

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[2]/a")).Click();
         //username
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("usamatahir693@gmail.com");
         //password
            driver.FindElement(By.XPath("//*[@id='pass']")).SendKeys("Usama@4489");
         //login button
            driver.FindElement(By.XPath("//*[@id='send2']/span")).Click();
            //valtidation

            // IWebDriver driver = new ChromeDriver();
            //  driver.Url = "https://magento.softwaretestingboard.com/";
            //  driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[2]/a")).Click();

            // enter username and password
            //  driver.FindElement(By.Id("email")).SendKeys("usamatahir693@gmail.com");
            //  driver.FindElement(By.Id("pass")).SendKeys("Usama@4489");

            // click login button
            //  driver.FindElement(By.Id("send2")).Click();

            // validate login
           // string Text = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[1]/span")).Text;
           // string welcomeMessage = driver.FindElement(By.CssSelector(".welcome-msg > .hello > span")).Text;
         //Assert.AreEqual("Welcome, Usama Tahir!",Text);



           

         // Assert.AreEqual("Welcome, Usama Tahir!", driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[1]/span")));
         //  Assert.AreEqual("Welcome, Usama Tahir!", "Welcome, Usama Tahir!");

         //Validate that the product is shown according to the applied filters. Go to What’s New -> Go to
         // Jackets under New In WOMEN’s->Select Size ‘XL’ -> Select Price ‘$60.00 - $69.99’ -> Select
         //  Color Black->After Applying these filter select the first item from the grid and validate that
         //  either its according to the applied filter’s or not.

         //whatsnew
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/nav/ul/li[1]/a/span")).Click();
         //jackets
            driver.FindElement(By.XPath("//*[@id='maincontent']/div[4]/div[2]/div/div/ul[1]/li[2]/a")).Click();
         //size
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div/div[2]/div[1]")).Click();
         // XL
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div/div[2]/div[2]/div/div/a[5]/div")).Click();
         // price
            driver.FindElement(By.XPath("/ html / body / div[1] / main / div[3] / div[2] / div / div[2] / div[3] / div[2] / div[1]")).Click();
         // 60$ - 69.99$
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div[3]/div[2]/div[2]/ol/li[3]/a")).Click();
         // colour
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div[3]/div[2]/div[1]")).Click();
         //black
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[3]/div[2]/div/div[2]/div[3]/div[2]/div[2]/div/div/a[1]/div")).Click();
         //selecting first item in grid and validating



         // Add an item to your Wish List. Go to Gear -> Go to Fitness Equipment -> Click on the first item -> 
         // Add that item to your wish list->Go to Manage My Account -> Go to My Wishlist -> Validate
         //  that item should be added in the wish list.

         //Gear
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/nav/ul/li[4]")).Click();
         //fitness equipment
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[4]/div[2]/div[1]/div[2]/dl/dd/ol/li[2]/a")).Click();
         //click on first item 
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[3]/div[1]/div[3]/ol/li[1]/div/a/span/span/img")).Click();
         //adding to wish list
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div[1]/div[5]/div/a[1]/span")).Click();
         // manage my account
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[2]/span/button")).Click();
         // my wish list
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[2]/div/ul/li[2]")).Click();
         // validation



         // Validate that review is submitted against the product. Search for the ‘Selene Yoga Hoodie’ -> 
         //  Select the first item from the grid ->Add Review Against it->Submit Review->Go to My
         //  Account->Go to My Product Reviews. Validate that the added review is saved or not.











            Thread.Sleep(5000);
            driver.Close();


            //driver.Manage().Window.Maximize();
            //driver.Url = "https://demoqa.com/automation-practice-form";
            //driver.FindElement(By.Id("firstName")).SendKeys("Abdul");
            //driver.FindElement(By.Id("lastName")).SendKeys("Ahad");
            //driver.FindElement(By.Id("userEmail")).SendKeys("abx@gmail.com");
            //driver.FindElement(By.ClassName("custom-control-label")).Click();
            //driver.FindElement(By.Id("userNumber")).SendKeys("0900786010");
            //driver.FindElement(By.Id("userNumber")).SendKeys(Keys.Tab);
            //driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("28-March-2023");
            //driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Enter);
            //driver.FindElement(By.Id("subjectsInput")).SendKeys("Math");
            //driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Enter);
            //driver.FindElement(By.Id("hobbies-checkbox-1")).SendKeys(Keys.Space);
            //driver.FindElement(By.Id("hobbies-checkbox-2")).SendKeys(Keys.Space);
            //driver.FindElement(By.Id("hobbies-checkbox-3")).SendKeys(Keys.Space);
            //IWebElement picture = driver.FindElement(By.Id("uploadPicture"));
            //string picturePath = "C:\\Users\\ahadeabd\\Pictures\\Screenshots";
            //picture.SendKeys(picturePath);
            // driver.FindElement(By.Id("currentAddress")).SendKeys("abc badami bagh");
            //driver.FindElement(By.Id("state")).Click();
            //driver.FindElement(By.XPath("//div[contains(text(),'Haryana')]")).Click();
            //driver.FindElement(By.Id("city")).Click();
            //driver.FindElement(By.XPath("//div[contains(text(),'Panipat')]")).Click();
            //driver.FindElement(By.Id("submit")).Click();


        }
    }
}
