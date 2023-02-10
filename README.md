# Playbook

1. Coin Jar Application
- Restore DB CoinJar
- Update connectionstring in the API (appsettings.json) to connect to the database.
- I have used my own object generator which acts as a sort of ORM layer, this is found in the GeneratedObjects folder
- Retrieving and updating the data for the coin jar has been done in the database via stored procedures called from the API.
