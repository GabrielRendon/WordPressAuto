﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace WordPress.Framework.Browser
{
    public class DriverManager
    {
        public IWebDriver DriverFactory()
        {
            IWebDriver instance;
            string driverVersion = "Chrome"; //Firefox, Chrome, IE

            switch (driverVersion)
            {
                case "Firefox":
                    instance = new FirefoxDriver();
                    break;
                case "Chrome":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("disable-infobars");
                    chromeOptions.AddArguments("--start-maximized");

                    instance = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory + @"\Drivers\", chromeOptions, TimeSpan.FromMinutes(2));
                    break;
                case "IE":
                    instance = new InternetExplorerDriver();
                    break;
                default:
                    instance = new FirefoxDriver();
                    break;
            }

            return instance;
        }
    }
}
