# LogginApplication
Log Application

This application is designed to show a way to modularize a logging application. The Logging solution is the front end. The dependencies in this are for all the modules. It takes the class from the database module and uses that to instantiate the service module. The service module and databaselayer module are not dependent on each other. The only module that is a common dependent is the Model module. This allows for one project to hold all of the classes/interfaces ect. that are needed and can be used for any and all applications.

# Set Up
After downloading the repository in visual studio open the "Logging.sln" file. 
Set the "Logging" project as the start up project.

