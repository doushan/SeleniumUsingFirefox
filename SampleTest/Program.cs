using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new FirefoxDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://www.pampers.com");
            //Thread.Sleep(5000);
            //driver.Quit();

            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.pampers.com/registration");
 

            //driver.FindElement(By.XPath(".//*[@id='lst-ib']")).SendKeys("Pampers");
            //driver.FindElement(By.XPath(".//*[.//*[@name='btnG']]")).Click();

            //driver.FindElement(By.Id(".//*[@id='gs_htif0']")).SendKeys("Pampers");
            //driver.FindElement(By.Id(".//*[.//*[@name='btnK']]")).Click();

          //driver.FindElement(By.Xpath(".//*[.//*[@name="btn"]]”).Click();

            driver.FindElement(By.Id("phdesktopbody_0_imgmale")).Click();
           // driver.FindElement(By.Id("phdesktopbody_0_imgfemale")).Click();

            driver.FindElement(By.XPath(".//*[@name='phdesktopbody_0$grs_consumer[firstname]']")).SendKeys("Tom");
            //driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[firstname]")).SendKeys("Doushan");

            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[lastname]")).SendKeys("Jerry");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][line1]")).SendKeys("Royal Road");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][line2]")).SendKeys("Vacoas");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][postalarea]")).SendKeys("123456");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][city]")).SendKeys("Vacoas");
            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[screenname]")).SendKeys("Doushan");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[emails][0][address]")).SendKeys("tom@live.com");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[password][password]")).SendKeys("qwertyu1");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[password][confirm]")).SendKeys("qwertyu1");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[phones][0][fulltelephonenumber]")).SendKeys("5710152700");

            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[birthdate][month]")).SendKeys("03");
            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[birthdate][year]")).SendKeys("1993");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][territory]")).SendKeys("Hawaii");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][birth_date][month]")).SendKeys("9");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][birth_date][day]")).SendKeys("3");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][birth_date][year]")).SendKeys("2015");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][gender]")).SendKeys("Boy");

            //driver.FindElement(By.Id("phdesktopbody_0_submit")).Click();

            //driver.FindElement(By.Id("phdesktopbody_0_grs_trait[1585][18302]")).Click();
            driver.FindElement(By.Id("phdesktopbody_0_submit")).Submit(); 
            
           // driver.FindElement(By.Name("btnG")).Click();
           
            //IWebElement body = driver.FindElement(By.TagName("body"));
            //body.SendKeys("Pampers");
            Thread.Sleep(500000);
            driver.Quit();

           
         
        }
    }
}
