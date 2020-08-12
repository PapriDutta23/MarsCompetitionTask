using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Global
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://192.168.99.100:5000";


        //Custom method for Click Operations
        public static void Click_Operation(IWebElement element)
        {
            element.Click();
        }

        //Custom method for Enter Text Operation
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);

        }
        //Custom methom for Selecting Dropdown method using "INDEX"
        public static void Drop_Down_Select_By_Index(IWebElement element, int index)
        {
            //creating an instance/object of SELECTELEMENT(This Class comes from Selenium.Support.UI Nuget package) type Class
            SelectElement choose = new SelectElement(element);

            choose.SelectByIndex(index);

        }
        //Custom methom for Selecting Dropdown method using "VALUE"
        public static void Drop_Down_Select_By_Value(IWebElement element, string value )
        {
            //creating an instance/object of SELECTELEMENT(This Class comes from Selenium.Support.UI Nuget package) type Class
            SelectElement choose = new SelectElement(element);

            choose.SelectByValue(value);

        }
        //Custom methom for Selecting Dropdown method using "TEXT"
        public static void Drop_Down_Select_By_Text(IWebElement element, string Text)
        {
            //creating an instance/object of SELECTELEMENT(This Class comes from Selenium.Support.UI Nuget package) type Class
            SelectElement choose = new SelectElement(element);

            choose.SelectByText(Text);

        }


    }
}
