param webAppName string = uniqueString(resourceGroup().id) // Generate unique String for web app name
//param sku string = 'F1' // The SKU of App Service Plan
param linuxFxVersion string = 'DOTNETCORE|7.0' // The runtime stack of web app
param location string = resourceGroup().location // Location for all resources

var appServicePlanName = toLower('rocmn-ua-b1-sp')
var appServiceName = toLower('${webAppName}')

resource appServicePlan 'Microsoft.Web/serverfarms@2020-06-01' existing = {
  name: appServicePlanName
}

resource appService 'Microsoft.Web/sites@2020-06-01' = {
  name: appServiceName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
    httpsOnly: true
    siteConfig: {
      linuxFxVersion: linuxFxVersion
      alwaysOn: true
      ftpsState: 'FtpsOnly'
    }
    clientAffinityEnabled: false
  }
}

