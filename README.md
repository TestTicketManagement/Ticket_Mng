## Overview
This is a ticket management API built using .NET Core 8 and Entity Framework 8.

# Requirements
Before any thing make sure you have :

- dotnetCore 8
- microsoftSQL sever 
- microsoft entity framwork
- texteditor like like visual studio

# Database
- make sure the databae you specified in the CONNECTION variable of your appsettings.json exists
- open the terminal (windows command prumpt or powershell) and run the migrations to create the tables of the database

dotnet ef database update 

# Run
- open the project in visual studio or vscode and run it
- The project should run on [http://localhost:5227](http://localhost:5227) and not on [https://localhost:5227](https://localhost:5227).
- API URL : http://localhost:5227/
- SWAGGER URL : http://localhost:5227/swagger/index.html
