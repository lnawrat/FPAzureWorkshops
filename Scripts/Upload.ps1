Write-Output "[Swap slots] Logging into the Azure."
Login-AzureRmAccount
Write-Output "[Swap slots] Logged in successfully."

Write-Output "[Swap slots] Selecting subscription."
Select-AzurermSubscription -SubscriptionId {Your-sub-guid}
Write-Output "[Swap slots] Subscription selected successfully."

Write-Output "[Swap slots] Swap slot."
