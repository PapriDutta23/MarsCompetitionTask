using MarsFramework.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.POM_Pages
{
    public class ChangePassword

        
    {
        public IWebDriver Driver;
       
        //Identifying "HI Papri" button
        IWebElement Hi_Name => GlobalDefinitions.driver.FindElement(By.XPath("//span[contains(@tabindex,'0')]"));

        //Identifying "CHANGE PASSWORD" from Dropdown box
        IWebElement Change_Pswrd => GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Change Password')]"));

        //Identifying "CURRENT PASSWORD" 
        IWebElement Crnt_Pswrd => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Current Password']"));

        //Identifying "NEW PASSWORD" 
        IWebElement Nw_Pswrd => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'New Password')]"));

        //Identifying "NEW PASSWORD" 
        IWebElement Cnfrm_Pswrd => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'Confirm Password')]"));

        //Identifying "CHANGE PASSWORD SAVE" 
        IWebElement Chng_Pswrd_Sv => GlobalDefinitions.driver.FindElement(By.XPath("//button[@type='button'][contains(.,'Save')]"));







        public void Password_Change()
        {
            //wait 
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//span[contains(@tabindex,'0')]"), 2000);

            //Click on "Hi Papri" button
            ConstantHelpers.Click_Operation(Hi_Name);

            //Wait for Element
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//a[@class='item'][contains(.,'Change Password')]"), 2000);

            //Click and SELECT "CHANGE PASSWORD" option
            ConstantHelpers.Click_Operation(Change_Pswrd);

            //Click "CURRENT PASSWORD" Field
            ConstantHelpers.Click_Operation(Crnt_Pswrd);

            //Sending Values to "CURRENT PASSWORD" Field
            ConstantHelpers.EnterText(Crnt_Pswrd, "123456");

            //Sending Values to "NEW PASSWORD" Field
            ConstantHelpers.EnterText(Nw_Pswrd, "234567");

            //Sending Values to "CONFIRM PASSWORD" Field
            ConstantHelpers.EnterText(Cnfrm_Pswrd, "234567");


            //Wait for Element
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//button[@type='button'][contains(.,'Save')]"), 2000);

            //Click "CHANGE PASSWORD SAVE" Click
            ConstantHelpers.Click_Operation(Chng_Pswrd_Sv);
        }










        
    }
}
