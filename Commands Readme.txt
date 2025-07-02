BackEnd-Commands
* Install the .NET SDK 6.0 by running:
	sudo apt install dotnet-sdk-6.0
	- If it asks for the password, provide password : pass@word1 

	 - If it asks: Do you want to continue? [Y/n]
		Type Y and press Enter.

* On command prompt, cd into your project folder (cd <Your-Project-folder>).

* To connect SQL  server from terminal:
(TaxManagement /sqlcmd -S localhost -U sa -P pass@word1)
	-To create database from terminal - 
	1> Create Database TaxDb
	2> Go

*	Steps to Apply Migration(Code first approach):
	- Press Ctrl+C to get back to command prompt
	- Run following command to apply migration-
             (TaxManagement /dotnet-ef database update)

* To check whether migrations are applied from terminal:
(TaxManagement /sqlcmd -S localhost -U sa -P pass@word1)

	1> Use TaxDb
	2> Go
	1> Select * From __EFMigrationsHistory
	2> Go

* To build your project use command:
	(TaxManagement /dotnet build)

* To launch your application, Run the following command to run the application:
	(TaxManagement /dotnet run)

* To test web-based applications on a browser, use the internal browser in the workspace. Click on the second last option on the left panel of IDE, you can find Browser Preview, where you can launch the application.
	Note: The application will not run in the local browser

* To run the test cases in CMD, Run the following command to test the application:
	(TaxManagement .Tests/dotnet test --logger "console;verbosity=detailed")
	(You can run this command multiple times to identify the test case status,and refactor code  to make maximum test cases passed before final submission)    
