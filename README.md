# Env
Before any thing make sure you have :

dotnetCore 8
microsoftSQL sever you can downloadit from here
microsoft entity framwork
texteditor like like visual studio

# Database
make sure the databae you specified in the CONNECTION variable of your appsettings.json exists
open the terminal (windows command prumpt or powershell) and run the migrations to create the tables of the database

dotnet ef database update 

# Build
open the project in visual studio or vscode and run it
API URL : http://localhost:5227/
SWAGGER URL : http://localhost:5227/swagger/index.html
