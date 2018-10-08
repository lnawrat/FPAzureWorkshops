# FPAzureWorkshops

## Basic information
Git hub repository: https://github.com/lnawrat/FPAzureWorkshops  
Virtual Machine: `lnawrat_Azure_workshops_2018-03_15.ova`  
VM credentials: `training` : `{you_know}`

## Exercises

### Exercise 1 - Deploy SQL database

1. Clone git repository:
```powershell 
git clone https://github.com/lnawrat/FPAzureWorkshops.git
```

2. Check out the `01-db` branch:
```powershell
git checkout 01-db
```

3. Run application locally - test the site.
4. Look into the local database through SQL Management Studio - see the new records.
5. Add a new SQL database in the Azure portal.
6. Connect to the new Azure database through SQL Management Studio - see the new records.
7. Replace the connection string in the application's web.config.
8. Test the site and see the new records in the Azure database.

### Exercise 2 - Deploy Web application

1. Restore previous database connection string in the web.config file - to point the local database.
2. Add a new Web App in the Azure portal.
3. Deploy application from Visual Studio to Azure - right click -> Publish.
4. Test the deployed Azure App by accessing azure url. It should fail because of database connection.
5. Set Azure database connection string through the Azure portal.
6. Test the deployed Azure App again.
7. See the new records in the Azure database.

### Exercise 3 - Swap deployment slots

1. Add a new deployment slot to the Azure Web App.
2. Test the new slot web application by accessing azure url.
3. Check out the `03-swapweb` branch:
```powershell 
git checkout 03-swapweb
```

4. Extend the `Scripts\Swap-WebAppSlot.ps1` poweshell script to make it swap the slots.
5. Use the [Azure Resource Explorer](https://resources.azure.com) portal for command details.

### Exercise 4 - Uploading file to Azure Storage Account

1. Test the uploading image form in the application. It is not working just yet.
2. Add a new Storage Account in the Azure portal.
3. Add the new Storage Account connection string to the application's web.config.
4. Install the `WindowsAzure.Storage` nuget package.
5. Implement missing code in `FilesStorageService` class – use the commented out code.
6. If needed use the msdn instructions: https://docs.microsoft.com/en-gb/azure/storage/blobs/storage-quickstart-blobs-dotnet .
7. Test the uploading image form in the application again.
8. Check out image urls.
9. Check out uploaded files in the Azure portal.

### Exercise 5 - Connecting to the Azure Virtual Machine

1. Add a new Azure Virtual Machine in the Azur portal. Use the Ubuntu version.
2. Connect to the new Virtual Machine's public IP through ssh:
```ssh
ssh myadmin@0.0.0.0
```
