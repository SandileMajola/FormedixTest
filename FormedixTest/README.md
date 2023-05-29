RIB CCS Assessment

Libraries used :

NUnit 3.12.0

.Net Core 3.1

Selenium Webdriver 3.141.0

Selenium Chrome Driver 91.0.4472.10100

Selenium Firefox Driver 0.27.0

Selenium Supprot 3.141.0

How To Run:

Clone Repo to your local machine
Open Project using Visual Studio
Tests are in the "TestScenario" files
Configuration to execute these tests are done through a .runSettings file which is in a folder "RunSettings", Please ensure you configure your Visual Studio to use this configuration file. Please refer to : docs.microsoft.com/en-us/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file?view=vs-2019
To run - Right click any of the "Tests" and select Run or Debug or alternatively you can run from the Test Explorer

To run in different browsers, Please update the runSettings file to the browser you want to run the tests.
![image](https://user-images.githubusercontent.com/35298568/124541666-31c23e80-de22-11eb-8bad-fd8208ba23de.png)

Please ensure when running on Chrome that you are on version 91.0.4472.10100.


There is 4 Scenarios :

A test of the Combined Scenarios

A test for each scenario

Page Object Model design pattern was used to store elements and functions in classes associated to the different pages.
