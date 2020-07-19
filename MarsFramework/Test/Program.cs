using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]



        class User : Global.Base
        {
            [Test]
            public void ShareSkillTest()
            {
               // Start Report
               test = extent.StartTest("ShareSkillTest");


                //Creating a new Instance of Shareskill page
                ShareSkill add = new ShareSkill();

                //Adding new share skill
                add.ShareSkillAdd();

            }
            [Test]
            public void validate()
            {
                // Start Report
                test = extent.StartTest("Validate Value");


                //Creating a new Instance of Shareskill page
                ShareSkill add = new ShareSkill();

                //Creating an Instance or object of Manage Listing Page
                ManageListings manage = new ManageListings();

                //Validation from Table of Manage Listing
                manage.Validate_ShareSkill_NewRecord();

            }
            [Test]
            public void EditNewRecord()
            {
                // Start Report
                test = extent.StartTest("EditNewRecord");

                //Creating an Instance of managelisting Page
                ManageListings New_Manage = new ManageListings();

                //Edit the Record with new data
                New_Manage.Edit_manage_Listing();

                
            }
            [Test]
            public void DeleteRecord()
            {
                // Start Report
                test = extent.StartTest("DeleteRecord");


                // Creating an Instance of managelisting Page
                ManageListings listing = new ManageListings();

                //Delete the Existing Record
                listing.Delete_Record();


            }

              
        }
    }
    
    
}