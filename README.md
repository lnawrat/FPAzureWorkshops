# FPAzureWorkshops

## Basic information
Git hub repository: https://github.com/lnawrat/FPAzureWorkshops  
Virtual Machine: `lnawrat_Azure_workshops_2018-03_15.ova`  
VM credentials: `training` : `{you_know}`

## Exercises

### Exercise 1 - Deploying SQL database

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
6. Connect to the new Azure database through SQL Management Studio - see the tables.
7. Replace the connection string in the application's web.config.
8. Test the site and see the new records in the Azure database.

### Exercise 2 - Deploying Web application

1. Restore previous database connection string in the web.config file - to point the local database.
2. Add a new Web App in the Azure portal.
3. Deploy application from Visual Studio to Azure - right click -> Publish.
4. Test the deployed Azure App by accessing azure url. It should fail because of database connection.
5. Set Azure database connection string through the Azure portal.
6. Test the deployed Azure App again.
7. See the new records in the Azure database.

### Exercise 3 - Swapping deployment slots

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
5. Implement missing code in the `FilesStorageService` class – use the commented out code. Use `blockBlob.Uri.AbsoluteUri`
to get blob new url.
6. If needed use the msdn instructions: https://docs.microsoft.com/en-us/azure/visual-studio/vs-storage-aspnet-getting-started-blobs#upload-a-blob-into-a-blob-container .
7. Test the uploading image form in the application again.
8. Check out the image urls.
9. Check out the uploaded files in the Azure portal.

### Exercise 5 - Sending Service Bus message from Azure Function

1. Add a new Azure Service Bus resource.
2. Inside Azure Service Bus, add a new Queue.
3. Save for later the queue name and the RootManageSharedAccessKey connection string.
4. Add a new Function App.
5. Add a new in-portal Function with Http trigger.
6. Test the new function by using http address in a browser.
7. In “Integrate” tab of the new Function add output “Azure Service Bus”.
8. Install (wait for installation) suggested extension.
9. Select parameters.
10. Extend the Function code save message – out string param, remove async. See Logs/Console for error details.
```C#
public static IActionResult Run(HttpRequest req, ILogger log, out string outMsg)
```
11. See in portal that new messages have been sent.


### Exercise 6 - Connecting to the Azure Virtual Machine

1. Add a new Azure Virtual Machine in the Azur portal. Use the Ubuntu Server OS.
2. Connect to the new Virtual Machine's public IP through ssh:
```ssh
ssh myadmin@0.0.0.0
```
