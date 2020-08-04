using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Threading;

namespace UnitTestProject2
{
    public class PracticePage

    {
        public static IWebDriver _webDriver;
        public ISearchContext driver = setup.Driver;
        public void SearchProduct()
        {
            driver.FindElement(By.Id("//input[@id='search_query_top']")).SendKeys("shirts");
            driver.FindElement(By.Id("//form[@id='searchbox']/button")).Click();
        }
        public void ScrollToButton()
        {
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)_webDriver;
            javaScript.ExecuteScript("window.scrollBy(0,2000)", "");
        }
        public void ClickonImage()
        {
            driver.FindElement(By.XPath("//div[@id='center_column']/ul/li/div/div[1]/div/a[1]/img")).Click();
            Thread.Sleep(500);
        }
        public void ClickOnAddcart()
        {
            driver.FindElement(By.XPath("//div[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span")).Click();
        }
        public void ClosePopup()
        {
            driver.FindElement(By.XPath("//span[@title='Close window']")).Click();
        }
        public void ClickOnSign()
        {
            driver.FindElement(By.XPath("//a[@class='login']")).Click();
        }
        public void EnterUsernameandpassword()
        {
            driver.FindElement(By.Id("//input[@id='email']")).SendKeys("dsfdsfdsfds");
            driver.FindElement(By.Id("//input[@id='passwd']")).SendKeys("sdfd");
            driver.FindElement(By.Id("//button[@id='SubmitLogin']")).Click();
        }
        public String ErrorMsg()
        {
            string value = driver.FindElement(By.Id("//p[contains(text(),'There is 1 error')]")).Text;
            return value;
        }
    }
}
