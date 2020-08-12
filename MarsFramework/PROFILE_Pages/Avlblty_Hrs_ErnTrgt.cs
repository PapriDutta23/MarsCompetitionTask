using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;




namespace MarsFramework.PROFILE_Pages
{
    class Avlblty_Hrs_ErnTrgt
    {
        //Identifying The "LOCATION" Globe Sign
        IWebElement Location => GlobalDefinitions.driver.FindElement(By.XPath("//i[contains(@class,'large globe icon')]"));
        //Identifying the "AVAILABILITY " update symbol
        IWebElement AvailabilityUpdate => GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[1]"));

        //Identifying the availability dropdown
        IWebElement AvailabilityDropdown => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyType')]"));

        //Identifying the  hours update symbol
        IWebElement HoursUpdate => GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[2]"));

        //Identifying the  availability hours pen like button
        IWebElement HoursDropdown => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyHour')]"));

        //Identifying the Earn Target update button
        IWebElement EarnTargetUpdate => GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[3]"));

        //Identifying the Earn Target pen like button
        IWebElement EarnTargetDropdown => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyTarget')]"));

        public void AddAvailability()
        {
            //Clicking the availabilityy update sign
            AvailabilityUpdate.Click();

            //Clicking the availability dropdown and then choosing value by Text
            AvailabilityDropdown.Click();
            AvailabilityDropdown.SendKeys("Full Time");
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//select[contains(@name,'availabiltyType')]"), 3000);
            AvailabilityDropdown.Click();
            //SuccessAlert();

        }
        public void AddHours()
        {
            //Clicking the hour update sign
            HoursUpdate.Click();

            //Clicking the Hours dropdown 
            HoursDropdown.Click();
            HoursDropdown.SendKeys("As needed");
            HoursDropdown.Click();
           // SuccessAlert();

        }
        public void AddEarnTarget()
        {

            //Clicking the Earn Target update button
            EarnTargetUpdate.Click();

            //Clicking the Earn Target pen like button
            EarnTargetDropdown.Click();
            EarnTargetDropdown.SendKeys("More than $1000 per month");
            EarnTargetDropdown.Click();


        }

        public void SuccessAlert()
        {
            //var wait = new WebDriverWait(GlobalDefinitions.driver, new TimeSpan(0, 0, 10));
            //wait.Until(WaitDriver => WaitDriver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text.Contains("Availability updated"));
            //Wait 
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath(" //div[@class='ns-box-inner'][contains(.,'Availability updated')]"), 3000);
            IWebElement ValueAlert = GlobalDefinitions.driver.FindElement(By.XPath(" //div[@class='ns-box-inner'][contains(.,'Availability updated')]"));
            //Get the Text of the "Updated Alert message"

            string Value_Alert_Text = ValueAlert.Text;

            Assert.AreEqual(ValueAlert.Text, "Availability updated");
        }





        //div[@class='ns-box-inner'][contains(.,'Availability updated')]



    }
}
