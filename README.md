Formedix Technical Assessment

Completed By Sandile Majola

Framework Used : Selenium (C#)
Browser Used : Chrome (Version 113.0.5672.127 (Official Build) (64-bit))

Design Pattern : Page Object Model 

To Execute the test :

1. Pull the repo to your local machine
2. Update NUGET package to pull down the dependecies
3. Select the runsettings file like below  
![image](https://github.com/SandileMajola/FormedixTest/assets/35298568/bc7c8a14-5d55-4dca-a3f1-b9663a2ea4b5)

4. Go to TestScenarios class
5. Right click on the test and select debug or run test.

Please make sure you are using the above browser version, if not - Please update the Selenium.WebDriver.ChromeDriver to your relevant browser.

Pages Folder : This folder is to hold the different classes associated with the application screens.
RunSettings Folder : This folder is to hold the runsettings file(s).

TestSetup Class : This class is used to initiate the selenium driver and also teardown once the test(s) have completed executing.
