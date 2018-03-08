using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace TestBetman
{
    [TestFixture]
    public class TestClassA
    {
        public static IWebDriver dr;

        [Test]
        public void setup()
        {
           // dr = new ChromeDriver();


            IWebDriver dr = new ChromeDriver(@"E:\Suman\Softwares\Cell\Visual Studio\Driver");
            dr.Navigate().GoToUrl("http://172.17.3.13");
              dr.Manage().Window.Maximize();

            //  dr.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            TestClassSuite.TestSuite(dr);       //  Call the TestSuite Class by calling object and passing public variables


        }


        /*   [OneTimeTearDown]
           public void EndReport()
           {
               dr.Close();                        //   Closing the Browser
           }*/
    }
}
