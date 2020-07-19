using AutoItX3Lib;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Threading;


namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {

            ExcelLibHelp.PopulateInCollection(@"MarsFramework\ExcelData\TestDataShareSkill.xlsx", "Share Skill");
           // ExcelLibHelp.PopulateInCollection(@"C:\Users\abhij\Desktop\Competition Task My work\marsframework(Cloned)\MarsFramework\ExcelData\TestDataShareSkill", "Share Skill");
             PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "(//input[contains(@placeholder,'Add new tag')])[1]")]
        private IWebElement Tags { get; set; }

        //Select the HOURLY Basis Service Radio button
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'serviceType')])[1]")]
        private IWebElement Service_Type_Hourly { get; set; }

        //Select the One-Off Service Radio Button
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'serviceType')])[2]")]
        private IWebElement Service_Type_One_Off { get; set; }

        //Select the OnSite Location Type
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'locationType')])[1]")]
        private IWebElement Location_OnSite { get; set; }

        //Select the Online Location Type
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'locationType')])[2]")]
        private IWebElement Location_Online { get; set; }


        //Click on Start Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'startDate')]")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option(Absolute XPath Given in Solution file)
        //[FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]

        //private IWebElement SkillTradeOption { get; set; }

        //Click on Skill Trade Option
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'skillTrades')])[1]")]
        private IWebElement Skill_Trade_Option { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Click on Credit option
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'skillTrades')])[2]")]
        private IWebElement Credit_Option { get; set; }


        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Work Sample button
        [FindsBy(How = How.XPath, Using = "//i[contains(@class,'huge plus circle icon padding-25')]")]
        private IWebElement WorkSample { get; set; }

        ////Click on Active/Hidden option(Absolute X-Path given in solution file)
        //[FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        //private IWebElement ActiveOption { get; set; }

        //Click on "Active" Radio Button
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'isActive')])[1]")]
        private IWebElement active { get; set; }

        //Click on "Hidden" Radio Button
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'isActive')])[2]")]
        private IWebElement Hidden { get; set; }


        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
       

        public void ShareSkillAdd()
        {
            //Click on Share Skill Button on Profile Page
            Click_Action(ShareSkillButton);

            //Click TITLE Textbox 
            Click_Action(Title);

            //Sending Texts to Title box from Custom Method EnterText
            EnterText(Title, "Software Tester");

            //Click DESCRIPTION Dropdown
            Click_Action(Description);

            //Sending Values from Excel Library
            Description.SendKeys(ExcelLibHelp.ReadData(2, "Description"));

            //Click Category DropDown
            Click_Action(CategoryDropDown);

            //Selecting Values from  "CATEGORY" Dropdown box
            Drop_Down_Select(CategoryDropDown, "6");

            // Click Sub Category DropDown
            Click_Action(SubCategoryDropDown);

            //Selecting Values from "SUB CATEGORY" Dropdown Box
            Drop_Down_Select(SubCategoryDropDown, "4");


            //Entering Tags and then Hit ENTER button
            Tags.SendKeys(ExcelLibHelp.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            Global.GlobalDefinitions.wait(3000);
            //Select Service Type radio Button and Click
            selectServiceType();

            Global.GlobalDefinitions.wait(3000);
            //Select Location Type Radio button and then Click
            Click_Action(Location_OnSite);

            ////Select date time picker
            Global.GlobalDefinitions.wait(3000);
            Date_Time_Picker();

            Global.GlobalDefinitions.wait(13000);
            //Select Skill Trade Radio button and then click
            Click_Action(Credit_Option);

            Global.GlobalDefinitions.wait(3000);
            //Entering the Credit amount
            EnterText(CreditAmount, "30");

            
            //click on work Sample Huge + sign
            Click_Action(WorkSample);

            //Upload Work Sample
             FileUpload();


            //Enter Skill Exchange and then Hit Enter Button
            //SkillExchange.SendKeys(ExcelLibHelp.ReadData(2, "Skill-Exchange"));
            //SkillExchange.SendKeys(Keys.Enter);
            Global.GlobalDefinitions.wait(3000);

            //Click Save button
            Click_Action(Save);

        }


        //Custom Method for Click Action
        public void Click_Action(IWebElement element)
        {


            element.Click();
        }

        //Custom method for Enter Text Operation
        public void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Custom methom for Selecting Dropdown method
        public void Drop_Down_Select(IWebElement element, string index)
        {
            //creating an instance/object of SELECTELEMENT(This Class comes from Selenium.Support.UI Nuget package) type Class
            SelectElement choose = new SelectElement(element);

            choose.SelectByValue(index);

        }
        
        


        //Custom Method- Select Service Type 
        public void selectServiceType()
        {
            if (ExcelLibHelp.ReadData(2, "ServiceType") == "Hourly basis service")

            {
                Service_Type_Hourly.Click();
            }
            else
            {
                Service_Type_One_Off.Click();


            }

           
        }

        public void FileUpload()
        {

          //  Click_Action(WorkSample);
            //creatng an instance/object  of AutoItX3 class type
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActive("Open");

            Thread.Sleep(1000);
            AutoIt.Send(@"C:\Users\abhij\Desktop\Competition Task My work\marsframework(Cloned)\File upload\File.txt");
            AutoIt.Send("{Enter}");

        }

        public void Date_Time_Picker()
        {
            //Select Starting Date from Excel
            StartDateDropDown.SendKeys(ExcelLibHelp.ReadData(2, "Startdate"));
            
            //Select Ending Date from Excel
            EndDateDropDown.SendKeys(ExcelLibHelp.ReadData(2, "Enddate"));
            


            ////Select Starting time from Excel
            //StartTimeDropDown.SendKeys(ExcelLibHelp.ReadData(2, "Starttime"));
            ////Select Endignng time from Excel
            //StartTimeDropDown.SendKeys(ExcelLibHelp.ReadData(2, "Endtime"));


            for (int i = 1; i <= 7; i++)
            {
                var day_checkbox = GlobalDefinitions.driver.FindElement(By.XPath("(//input[contains(@name,'Available')])[" + i + "]"));
                var StartTime = GlobalDefinitions.driver.FindElement(By.XPath("(//input[contains(@name,'StartTime')])[" + i + "]"));
                var EndTime = GlobalDefinitions.driver.FindElement(By.XPath("(//input[contains(@name,'EndTime')])[" + i + "]"));
                var label = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='fields'][" + (1 + i) + "]/div/div//label"));


                if (ExcelLibHelp.ReadData(2, "Selectday") == label.Text)
                {
                    Click_Action(day_checkbox);
                    
                    StartTime.SendKeys(ExcelLibHelp.ReadData(2, "Starttime"));
                    EndTime.SendKeys(ExcelLibHelp.ReadData(2, "Endtime"));

                }

            }
        }
        
        //Custom method for Radio button
        //public void Radio_Button_Select(IWebElement element, IWebElement element2, int value)

        //{
        //    //creating an instance/object of SELECTELEMENT(This Class comes from Selenium.Support.UI Nuget package) type Class
        //    SelectElement choose = new SelectElement(element);
        //    SelectElement choose2 = new SelectElement(element2);
        //    if (element.GetAttribute("value").Equals(0))

        //    {
        //        Click_Action(element);
        //    }
        //    else
        //    {
        //        Click_Action(element2);
        //    }

        //}

       


    }
}