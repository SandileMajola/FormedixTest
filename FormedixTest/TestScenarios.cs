using NUnit.Framework;
using FormedixTest.Pages;

namespace FormedixTest
{
    public class Tests : TestSetup
    {
        [Test]
        public void TestCase_101()
        {
            LoginScreen loginScreen = new LoginScreen(driver); //Login Screen Object
            HomeScreen homeScreen = new HomeScreen(driver); //Home Screen Object
            TechStudyScreen techStudyScreen = new TechStudyScreen(driver); //Tech Study Screen Object
            DataAcquisitionScreen dataAcquisitionScreen = new DataAcquisitionScreen(driver); //Data Acquisition Object
            FormsViewScreen formsViewScreen = new FormsViewScreen(driver); //Forms View Object

            loginScreen.Login();

            homeScreen.NavigateToStudies();
            homeScreen.NavigateToViewTechStudy();

            techStudyScreen.ClickDataAcquisition();

            dataAcquisitionScreen.ClickAssetForms();

            formsViewScreen.ClickMedicalHistory();
            formsViewScreen.ClickEditButton();

            string description = "This description was updated by Kgothatso Collen Mohlala11.";

            formsViewScreen.EditDescriptionField(description);
            formsViewScreen.LogOut();

        }
    }
}