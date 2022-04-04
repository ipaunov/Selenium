using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System;

namespace Selenium
{
    class SeleniumExercise8
    {
        WebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test, Order(0)]
        public void FindElementTest()
        {
            driver.Url = "http://demo.guru99.com/test/ajax.html";

            driver.FindElement(By.Id("no")).Click();

            driver.FindElement(By.Id("buttoncheck")).Click();
        }

        [Test, Order(1)]
        public void FindElementsTest()
        {
            driver.Url = "http://demo.guru99.com/test/ajax.html";

            IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Name("name"));

            Console.WriteLine("Number of elements:" + elements.Count);

            foreach(IWebElement webElement in elements)
            {
                Console.WriteLine("Radio button text:" + webElement.GetAttribute("value"));
            }
        }

        [Test, Order(2)]
        public void InputBoxTest()
        {
            driver.Url = "http://demo.guru99.com/test/login.html";

            IWebElement email = driver.FindElement(By.Id("email"));

            IWebElement password = driver.FindElement(By.Id("passwd"));
        }

        [Test, Order(3)]
        public void SendKeysTest()
        {
            driver.Url = "http://demo.guru99.com/test/login.html";

            IWebElement email = driver.FindElement(By.Id("email"));

            IWebElement password = driver.FindElement(By.Id("passwd"));

            email.SendKeys("abcd@gmail.com");

            password.SendKeys("abcdefg");
        }

        [Test, Order(3)]
        public void SubmitTest()
        {
            driver.Url = "http://demo.guru99.com/test/login.html";

            IWebElement email = driver.FindElement(By.Id("email"));

            IWebElement password = driver.FindElement(By.Id("passwd"));

            IWebElement login = driver.FindElement(By.Id("SubmitLogin"));

            email.SendKeys("abcd@gmail.com");

            password.SendKeys("abcdefg");

            login.Click();

        }

    }
}
