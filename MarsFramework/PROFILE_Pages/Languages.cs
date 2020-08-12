using MarsFramework.Global;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.PROFILE_Pages
{
    public class Languages
    {
        //Identifying the language button
        IWebElement lnguageTab => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));

        //Identifying add new button 
        IWebElement addnewlanguage => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));

        //Identifying Update Button                                           
        IWebElement update => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));

        //Identifying add language text button and then click  , sending value
        IWebElement addlanguagetxt => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        //html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input

        //Identifying the language level dropdown and then click ,  , sending value
        IWebElement languagelevel => GlobalDefinitions.driver.FindElement(By.XPath("//*[contains(@name , 'level')]"));

        //Identifying the add button
        IWebElement languageadd => GlobalDefinitions.driver.FindElement(By.XPath("(//input[contains(@value,'Add')])"));

        //Identifying the FIRST DATA TAB LANGUAGE section and the click
        IWebElement LanguageTab => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));

        //Get The Langauge Text Text Box
        IWebElement LnguageTxtBx => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));

        //Get The level DropDown Box
        IWebElement LngLvlDrpdwn => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'level')]"));



        public void addlanguage()
        {
            //Click on Language Data tab
            lnguageTab.Click();

            //Click on "Add New" Button
            GlobalDefinitions.wait(10);
            addnewlanguage.Click();

            //Click on Language Text
            GlobalDefinitions.wait(30);
            ConstantHelpers.Click_Operation(addlanguagetxt);

            //Entering language name in language Text Box
            ConstantHelpers.EnterText(addlanguagetxt, "Spanish");

            //Click On Language Level Drop Down and Select the Level
            ConstantHelpers.Click_Operation(languagelevel);
            ConstantHelpers.Drop_Down_Select_By_Text(languagelevel, "Conversational");

            //Identifying the add button, click , sending value
            GlobalDefinitions.wait(10);
            ConstantHelpers.Click_Operation(languageadd);

        }

        public void UpdateLanguage()
        {
            //Click FIRST DATA TAB LAGUAGE
            ConstantHelpers.Click_Operation(LanguageTab);

            try
            {
                //Identifying pen like update sign icon from "Language" Table  and then click
                for (int i = 1; i <= 4; i++)
                {


                    //Get the Text Of The "Language"
                    string LngTxt = GlobalDefinitions.driver.FindElement(By.XPath("//*[@data-tab ='first']/div/div/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Get the Text of the "Level" of language                                                                                                                 
                    string LvlTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    if (LngTxt == "Spanish" && LvlTxt == "Conversational")
                    {
                        //Identify Language Update Pen
                        IWebElement LanguageUpdatePen = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]"));
                        GlobalDefinitions.wait(30);

                        //Click on Update Pen Icon
                        ConstantHelpers.Click_Operation(LanguageUpdatePen);

                        //Click Language Text Box
                        ConstantHelpers.Click_Operation(LnguageTxtBx);

                        //Clear the Text Box
                        LnguageTxtBx.Clear();

                        //Send data To "Language Text Box"
                        GlobalDefinitions.wait(30);
                        LnguageTxtBx.SendKeys("FRENCH");

                        //Select level value from Dropdown Box
                        GlobalDefinitions.wait(30);
                        ConstantHelpers.Drop_Down_Select_By_Text(LngLvlDrpdwn, "Basic");

                        //Click Update
                        ConstantHelpers.Click_Operation(update);
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
        public void DeleteLanguage()
        {
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            ConstantHelpers.Click_Operation(LanguageTab);


            try
            {
                //Identifying Cross like Delete sign icon from "Language" Table  and then click
                for (int i = 1; i <= 4; i++)
                {
                    //Get the Text Of The "Language"
                    string LngTxt = GlobalDefinitions.driver.FindElement(By.XPath("//*[@data-tab ='first']/div/div/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    if (LngTxt == "Spanish")
                    {
                        //Identify The "CROSS" delete Sign
                        IWebElement DltIcon = GlobalDefinitions.driver.FindElement(By.XPath("//form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i"));
                        GlobalDefinitions.wait(30);

                        //Click on Delete Icon
                        ConstantHelpers.Click_Operation(DltIcon);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //

            ////Get the table row list
            //IList<IWebElement> Tablerows = GlobalDefinitions.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));

            ////Count the No of Rows
            //var count = Tablerows.Count;

            ////Identifying "Cross" Delete Sign  from "Language" Table  and then click
            //for (var i = 1; i <= count;  i++)
            //{
            //    //xpath of ith languagename(row)
            //    String Actl_Vlu_Lng= GlobalDefinitions.driver.FindElement(By.XPath("//div/table/tbody[" + i + "]/tr/td[1]")).Text;
            //    if (Expctd_Vlu_Lng == Actl_Vlu_Lng)
            //    {


            //        //click on delete icon
            //        GlobalDefinitions.driver.FindElement(By.XPath("//div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();

            //        Console.WriteLine("Language has been deleted");
            //    }
            //    break;


            //}

        }
        public void ValidateAddLanguage()
        {
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            ConstantHelpers.Click_Operation(LanguageTab);


            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Language"
                var LngTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "Level" of language                                                                                                                 
                var LvlTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (LngTxt == "Spanish" && LvlTxt == "Conversational")
                    {
                        Console.WriteLine("Added Language has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }


        }
        public void Validate_Update_language()
        {
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            ConstantHelpers.Click_Operation(LanguageTab);

            try
            {

                for (int i = 1; i <= 3; i++)
                {
                    //Get the Text Of The "Language"
                    var LngTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Get the Text of the "Level" of language                                                                                                                 
                    var LvlTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;


                    if (LngTxt == "French" && LvlTxt == "Basic")
                    {
                        Console.WriteLine("Updated Language has been Validated");
                        break;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }

        public void ValidateDelLanguage()
        {
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            ConstantHelpers.Click_Operation(LanguageTab);


            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Language"
                var LngTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "Level" of language                                                                                                                 
                var LvlTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (LngTxt != "Spanish" && LvlTxt != "Conversational")
                    {
                        Console.WriteLine("Deleted Language has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }


        }
    }
}

//developer  string LngTxt = GlobalDefinitions.driver.FindElement(By.XPath("//div/table/tbody[" + i + "]/tr/td[1]")).Text;