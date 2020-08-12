using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    public class SearchSkills
    {
        //Identify The "SEARCH" Skill Tab
        IWebElement search => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'Search skills')]"));

        //Identify "SERACH" icon
        IWebElement Search_Icon => GlobalDefinitions.driver.FindElement(By.XPath("(//i[contains(@class,'search link icon')])[1]"));

        //Identify the "All categories" tab
        IWebElement All_Category => GlobalDefinitions.driver.FindElement(By.XPath("//b[contains(.,'All Categories')]"));

        //Identify the"Category" of Required skill 
        IWebElement Prgrmng_Tch => GlobalDefinitions.driver.FindElement(By.XPath("//a[@role='listitem'][contains(.,'Programming & Tech459')]"));

        //Identify the "Search skills" Text Box
        IWebElement Search_Skills_TxtBx => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[2]/input"));
       
        //Identify the "Search Skill" Circle Sign
        IWebElement Search_Skill_Sign => GlobalDefinitions.driver.FindElement(By.XPath("//i[contains(@class,'search link icon')]"));

        //Identify the "Search user" Text box   
        IWebElement Search_User_TxtBx => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));

        //Identify Entering Name  text box in "Search User"
        IWebElement Enter_Name_Txt => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div/div/span"));

        //Identify SEARCH icon "SEARCH SKILL"
        IWebElement Search_Sign => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[2]/i"));

        //Identify the "ONLINE" Filter button
        IWebElement Online => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[5]/button[1]"));

         //Identify the  "ONSITE" Filter Button
        IWebElement onsite => GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(.,'Onsite')]"));

        //Identify Name label from Profile
        IWebElement Name_Label => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/div[1]/a[1]"));

        //Identify Description label from Profile
        IWebElement Dscrptn_Label => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/div[1]/a[2]/p"));





        public void SkillSearch_By_AllCategories()
        {
            //    //Click the "SEARCH" Skill tab
            //    Click_Operation(search);

            //Click On The "SEARCH ICON"
            GlobalDefinitions.wait(30);
            ConstantHelpers.Click_Operation(Search_Icon);

            //Click on "All Categories" tab
            GlobalDefinitions.wait(30);
            ConstantHelpers.Click_Operation(All_Category);
            GlobalDefinitions.wait(30);

        }
        public void SkillSearch_By_SubCateogory()
        {
            //Click On The "SEARCH ICON"
            GlobalDefinitions.wait(30);
            ConstantHelpers.Click_Operation(Search_Icon);

            try
            {
                ////Traversing Through The Subcategories
                //for (int i = 1; i <= 6; i++)
                //{
                //Finding the element " Category"
                IWebElement Ctgry_Lbl = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[1]/div/a[7]"));

                //Click the " Category" label
                Ctgry_Lbl.Click();

                //Get the Text of the " Category"
                string Ctgry_Txt = Ctgry_Lbl.Text;

                //Wait For element
                if (Ctgry_Txt == "Programming & Tech")
                {
                    for (int i = 8; i <= 13; i++)
                    {

                        //Finding The "Sub Category" 
                        IWebElement SubCategry_Lvl = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[1]/div/a[" + i + "]"));

                        //Get the Sub Category Text
                        string SubCategry_Lvl_Txt = SubCategry_Lvl.Text;

                        if (SubCategry_Lvl_Txt == "QA")
                        {
                            SubCategry_Lvl.Click();
                            GlobalDefinitions.wait(6000);
                            break;

                        }

                    }

                }
                //Wait for element to be visible whose Photo(Name Jignesh Patel) is Showing 
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[3]/div[1]/a[1]"), 6000);
            }
            catch (Exception)
            {
                Console.WriteLine("Test Case Failed");

            }

            ////Wait For element 
            //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("(//a[contains(@class,'item subcategory')])[4]"), 1000);


            ////Drop down selection
            //Select_Drop_Down(Prgrmng_Tch, "QA");
        }
        public void Search_By_Filter()
        {
            //Click On The "SEARCH ICON"
            ConstantHelpers.Click_Operation(Search_Icon);

            //Wait For "element" 
            //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div/div/span"), 3000);

            //Click Search User
            ConstantHelpers.Click_Operation(Search_User_TxtBx);

            //Entering the user in "ENTER NAME" Text Box
            Search_User_TxtBx.SendKeys("papri dutta");

            //Click on "ENTER NAME " Text
            Enter_Name_Txt.Click();

            //Click the "Search user" button
            ConstantHelpers.Click_Operation(Search_Skills_TxtBx);

            //Enter "Skills" in "Search Skill" Text Box
            ConstantHelpers.EnterText(Search_Skills_TxtBx, "QA");

            //Click on SERCH Sign In SERACH SKILLS
            Search_Sign.Click();

            Thread.Sleep(6000);

            //Click On Online button
            Online.Click();

            //Click "ONSITE" button
            // Click_Operation(onsite);
        }
        public void Validation_Search_By_Filter()
        {
            //Search By Filter
            Search_By_Filter();

            //Get the Text of the Name
            string Name_Level_Txt = Name_Label.Text;

            //Get The Text of the Description 
            string Dscrptn_Label_Txt = Dscrptn_Label.Text;

            //Assertition of "NAME" and "DESCRIPTION" lebvel Text
            Assert.AreEqual(Name_Level_Txt , "Papri Dutta");
            Assert.AreEqual(Dscrptn_Label_Txt, "QA");
        }






































    }

    ////SElecting drop down box
    //public void Select_Drop_Down(IWebElement element , string value)

    //{
    //    //creating an instance/object of SELECTELEMENT(This Class comes from Selenium.Support.UI Nuget package) type Class
    //    SelectElement select = new SelectElement(element);
    //    select.SelectByText(value);



    //}
    
    //Custom method for Click Operations
    

}





















        


    

        



    

    

