# Playbook

Applications are built using Visual Studio.

1. Coin Jar Application
- Restore DB CoinJar.bak in the root of this project
- Update the ConnectionString in the API (appsettings.json) to connect to the database.
- I have used my own object generator which acts as a sort of ORM layer, this is found in the GeneratedObjects folder
- Retrieving and updating the data for the coin jar has been done in the database via stored procedures called from the API.
- To add a coin you can only enter values of (1,5,10,25,50,100) 100 being 100c or $1 in the amount field, any other values the program will say those coins do not exist.
- You could also assign the volume for each coin in the POST however if you don't it will be calculated with a CoinHelper with a case statement
- If you run the API it will load up swagger (automatic with .NET 6) which you can use to test, alternatively you can use postman.


