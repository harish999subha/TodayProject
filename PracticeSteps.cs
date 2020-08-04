using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [Binding]
    public class PracticeSteps
    {
        private PracticePage _practicePage;

        public PracticeSteps(PracticePage practicePage)
        {
           _practicePage=practicePage;
        }


        [Given(@"I go to the default Automation Practice URL")]
        [When(@"I go to the default Automation Practice URL")]
        public void DefaultURL(int number)
        {
            string var = ConfigurationManager.AppSettings["URL"];
        }
        [Given(@"I search the product for (.*)")]
        [When(@"I search the product for (.*)")]
        public void SearchProduct(string value)
            {
            _practicePage.SearchProduct();
            }
        [Given(@"I Scrolldown and Add to cart")]
        [When(@"I Scrolldown and Add to cart")]
        public void ScrolldownAddcart()
        {
            _practicePage.ScrollToButton();
            _practicePage.ClickonImage();
            _practicePage.ClickOnAddcart();
            _practicePage.ClosePopup();
        }
        [Then(@"I click on the sign button")]
        [When(@"I click on the sign button")]
        public void SignButton()
        {
            _practicePage.ClickOnSign();
        }
        [Given(@"I Enter EmailAddress and Password")]
        [When(@"I Enter EmailAddress and Password")]
        public void Enter()
        {
            _practicePage.ClickOnSign();
        }
        [When(@"I Validate the Error Msg")]
        [Then(@"I Validate the Error Msg")]
        public void ErrorMsg()
        {
            string Actual = _practicePage.ErrorMsg();
            try
            {
                Assert.AreEqual("There is 1 error", Actual);
            }
            catch
            {
                throw new Exception("Testcase failed");
            }

        }
    }
}
