# FPAzureWorkshops

## Basic information
Git hub repository: https://github.com/lnawrat/FPAzureWorkshops  
Virtual Machine: `lnawrat_Azure_workshops_2018-03_15.ova`  
VM credentials: `training` : `{you_know}`

## Exercises

### Exercise 1 - Deploy SQL database

1. Clone git repository
``` git 
git clone https://github.com/lnawrat/FPAzureWorkshops.git
```

2. Check out the `01-db` branch
``` git 
git checkout 01-db
```

3. Run application locally - test the site.
4. Look into the local database through SQL Management Studio - see the new records.
5. Add a new SQL database in the Azure portal.
6. Connect to the new Azure database through SQL Management Studio - see the new records.
7. Replace the connection string in the application's web.config.
8. Test the site and see the new record in the Azure database.
