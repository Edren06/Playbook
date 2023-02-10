# Playbook

Applications are built using Visual Studio.
I have used my own object generator which acts as a sort of ORM layer, this is found in the GeneratedObjects folders.
Retrieving and updating the data for the has been done in the database via stored procedures called from the API.
f you run the API it will load up swagger (automatic with .NET 6) which you can use to test, alternatively you can use postman.

1. Coin Jar Application
- Restore DB CoinJar.bak in the root of this project
- Update the ConnectionString in the API (appsettings.json) to connect to the database.
- To add a coin you can only enter values of (1,5,10,25,50,100) 100 being 100c or $1 in the amount field, any other values the program will say those coins do not exist.
- Run the API and use swagger (found the easiest)

2. Rugby Management App
- Restore DB RugbyManagement.bak in the root of this project
- Update the ConnectionString in the API (appsettings.json) to connect to the database.
- Run the API and use swagger (found the easiest)




