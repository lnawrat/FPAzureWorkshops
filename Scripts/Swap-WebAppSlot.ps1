Write-Output "[Swap slots] Logging into the Azure."
Login-AzureRmAccount
Write-Output "[Swap slots] Logged in successfully."

Write-Output "[Swap slots] Selecting subscription."
Select-AzurermSubscription -SubscriptionId {Your-sub-guid}
Write-Output "[Swap slots] Subscription selected successfully."

Write-Output "[Swap slots] Swap slot."

$parameters = @{ targetSlot = "stage" };
Invoke-AzureRmResourceAction `
    -ResourceGroupName {your_name} `
    -ResourceType Microsoft.Web/sites `
    -ResourceName {your_name} `
    -Action slotsswap `
    -Parameters $parameters `
    -ApiVersion 2018-02-01 `
    -Force
