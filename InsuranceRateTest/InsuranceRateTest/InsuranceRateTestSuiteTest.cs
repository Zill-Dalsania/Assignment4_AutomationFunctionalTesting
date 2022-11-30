﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class InsuranceRateTestSuiteTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    String baseUrl = "http://localhost/prog8170a04/";

    [Test]
    public void age25_Experience3_Accidents0()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(1528, 812);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Chaitanya");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Javvadi");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("84 weber street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 1Z9");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("647-891-8345");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("chaitu.javvadi@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }
    [Test]
    public void age25_Experience3_Accidents4()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(1528, 812);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Chaitanya");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Javvadi");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("84 weber street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 1Z9");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("647-891-8345");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@test.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void age35_Experience10_Accidents2()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(1528, 812);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
        driver.FindElement(By.Id("lastName")).SendKeys("Chaitanya");
        driver.FindElement(By.Id("address")).SendKeys("Karnamgari Street, 27-152");
        driver.FindElement(By.Id("city")).SendKeys("Penugonda");
        driver.FindElement(By.Id("email")).SendKeys("chaitu.javvadi@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("094-918-8345");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 1Z9");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1350"));
        }
    }
    [Test]
    public void invalidEmail_Age28_Experience3_Accidents0()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(1528, 812);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Chaitanya");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Javvadi");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("Weber street south");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 1Z9");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("647-891-8345");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("12345");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
    }
    [Test]
    public void invalidPhone_Age27_Experience3_Accidents0()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(1528, 812);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Zill");
        driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Dalsania");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("Weber street south");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 1Z9");
        driver.FindElement(By.Id("phone")).SendKeys("6478918345");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("zilldalsania@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
    }


}