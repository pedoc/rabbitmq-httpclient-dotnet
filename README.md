# Thinkcode.RabbitMQ.OpenAPI - the C# library for the Rabbitmq Http API

This is the OpenAPI specification of the RabbitMQ HTTP API. For more information, please refer to [HTTP API](https://cdn.rawgit.com/rabbitmq/rabbitmq-management/v3.7.14/priv/www/api/index.html) official documentation.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.2
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.linkedin.com/in/clozano/](https://www.linkedin.com/in/clozano/)

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.6.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.57.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Thinkcode.RabbitMQ.OpenAPI.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 
            var queue = queue_example;  // string | 
            var body = new BindingRequest(); // BindingRequest |  (optional) 

            try
            {
                // Create Bindings for Queue
                apiInstance.CreateBindingsForQueueExchange(vhost, exchange, queue, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.CreateBindingsForQueueExchange: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BindingsApi* | [**CreateBindingsForQueueExchange**](docs/BindingsApi.md#createbindingsforqueueexchange) | **POST** /bindings/{vhost}/e/{exchange}/q/{queue} | Create Bindings for Queue
*BindingsApi* | [**DeleteBindingForQueueExchange**](docs/BindingsApi.md#deletebindingforqueueexchange) | **DELETE** /bindings/{vhost}/e/{exchange}/q/{queue}/{propertyKey} | Delete Binding for Queue
*BindingsApi* | [**GetBindingForQueueExchange**](docs/BindingsApi.md#getbindingforqueueexchange) | **GET** /bindings/{vhost}/e/{exchange}/q/{queue}/{propertyKey} | Get Binding for Queue
*BindingsApi* | [**ListBindings**](docs/BindingsApi.md#listbindings) | **GET** /bindings | List Bindings
*BindingsApi* | [**ListBindingsAsDestination**](docs/BindingsApi.md#listbindingsasdestination) | **GET** /exchanges/{vhost}/{exchange}/bindings/destination | List Bindings as Destination
*BindingsApi* | [**ListBindingsAsSource**](docs/BindingsApi.md#listbindingsassource) | **GET** /exchanges/{vhost}/{exchange}/bindings/source | List Bindings as Source
*BindingsApi* | [**ListBindingsForQueue**](docs/BindingsApi.md#listbindingsforqueue) | **GET** /queues/{vhost}/{queue}/bindings | List All Bindings for Queue
*BindingsApi* | [**ListBindingsForQueueExchange**](docs/BindingsApi.md#listbindingsforqueueexchange) | **GET** /bindings/{vhost}/e/{exchange}/q/{queue} | List Bindings for Queue
*ExchangesApi* | [**CreateExchange**](docs/ExchangesApi.md#createexchange) | **PUT** /exchanges/{vhost}/{exchange} | Create Exchange
*ExchangesApi* | [**DeleteExchange**](docs/ExchangesApi.md#deleteexchange) | **DELETE** /exchanges/{vhost}/{exchange} | Delete Exchange
*ExchangesApi* | [**GetExchange**](docs/ExchangesApi.md#getexchange) | **GET** /exchanges/{vhost}/{exchange} | Read Exchange
*ExchangesApi* | [**ListExchanges**](docs/ExchangesApi.md#listexchanges) | **GET** /exchanges | List Exchanges
*ExchangesApi* | [**ListExchangesForHost**](docs/ExchangesApi.md#listexchangesforhost) | **GET** /exchanges/{vhost} | List Exchanges for VHost
*ExchangesApi* | [**PublishMessage**](docs/ExchangesApi.md#publishmessage) | **POST** /exchanges/{vhost}/{exchange}/publish | Publish Message
*InformationalApi* | [**GetClusterName**](docs/InformationalApi.md#getclustername) | **GET** /cluster-name | Read Cluster Name
*InformationalApi* | [**GetDefinitionsForVirtualHost**](docs/InformationalApi.md#getdefinitionsforvirtualhost) | **GET** /definitions/{vhost} | Get Definitions for VHost
*InformationalApi* | [**GetOverview**](docs/InformationalApi.md#getoverview) | **GET** /overview | Get Overview
*InformationalApi* | [**ListDefinitions**](docs/InformationalApi.md#listdefinitions) | **GET** /definitions | List Definitions
*PermissionsApi* | [**ListUserPermissions**](docs/PermissionsApi.md#listuserpermissions) | **GET** /users/{user}/permissions | List User Permissions
*PermissionsApi* | [**ListUsersTopicPermissions**](docs/PermissionsApi.md#listuserstopicpermissions) | **GET** /users/{user}/topic-permissions | List Users Topic Permissions
*PermissionsApi* | [**ListUsersWithoutPermissions**](docs/PermissionsApi.md#listuserswithoutpermissions) | **GET** /users/without-permissions | List Users without Permissions
*PubSubApi* | [**ConsumeMessage**](docs/PubSubApi.md#consumemessage) | **POST** /queues/{vhost}/{queue}/get | Consume Message
*PubSubApi* | [**PublishMessage**](docs/PubSubApi.md#publishmessage) | **POST** /exchanges/{vhost}/{exchange}/publish | Publish Message
*QueuesApi* | [**ConsumeMessage**](docs/QueuesApi.md#consumemessage) | **POST** /queues/{vhost}/{queue}/get | Consume Message
*QueuesApi* | [**CreateQueue**](docs/QueuesApi.md#createqueue) | **PUT** /queues/{vhost}/{queue} | Create Queue
*QueuesApi* | [**CreateQueueActions**](docs/QueuesApi.md#createqueueactions) | **POST** /queues/{vhost}/{queue}/actions | Create Actions for Queue
*QueuesApi* | [**DeleteQueue**](docs/QueuesApi.md#deletequeue) | **DELETE** /queues/{vhost}/{queue} | Delete Queue
*QueuesApi* | [**DeleteQueueContents**](docs/QueuesApi.md#deletequeuecontents) | **DELETE** /queues/{vhost}/{queue}/contents | Delete Queue Contents (Purge)
*QueuesApi* | [**GetQueue**](docs/QueuesApi.md#getqueue) | **GET** /queues/{vhost}/{queue} | Get Queue
*QueuesApi* | [**ListBindingsForQueue**](docs/QueuesApi.md#listbindingsforqueue) | **GET** /queues/{vhost}/{queue}/bindings | List All Bindings for Queue
*QueuesApi* | [**ListQueues**](docs/QueuesApi.md#listqueues) | **GET** /queues | List Queues
*QueuesApi* | [**ListQueuesForVirtualHost**](docs/QueuesApi.md#listqueuesforvirtualhost) | **GET** /queues/{vhost} | List Queues for VHost
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **PUT** /users/{name} | Create User
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /users/{name} | Delete User
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /users/{name} | Get User
*UsersApi* | [**GetUserCurrent**](docs/UsersApi.md#getusercurrent) | **GET** /whoami | Get Current User
*UsersApi* | [**ListUserPermissions**](docs/UsersApi.md#listuserpermissions) | **GET** /users/{user}/permissions | List User Permissions
*UsersApi* | [**ListUsers**](docs/UsersApi.md#listusers) | **GET** /users | List Users
*UsersApi* | [**ListUsersWithoutPermissions**](docs/UsersApi.md#listuserswithoutpermissions) | **GET** /users/without-permissions | List Users without Permissions
*VirtualHostsApi* | [**CreateDefinitionsForVirtualHost**](docs/VirtualHostsApi.md#createdefinitionsforvirtualhost) | **POST** /definitions/{vhost} | Create Definitions for VHost
*VirtualHostsApi* | [**CreateVirtualHost**](docs/VirtualHostsApi.md#createvirtualhost) | **PUT** /vhosts/{vhost} | Create VHost
*VirtualHostsApi* | [**DeleteVirtualHost**](docs/VirtualHostsApi.md#deletevirtualhost) | **DELETE** /vhosts/{vhost} | Delete VHost
*VirtualHostsApi* | [**GetDefinitionsForVirtualHost**](docs/VirtualHostsApi.md#getdefinitionsforvirtualhost) | **GET** /definitions/{vhost} | Get Definitions for VHost
*VirtualHostsApi* | [**GetVirtualHost**](docs/VirtualHostsApi.md#getvirtualhost) | **GET** /vhosts/{vhost} | Read VHost
*VirtualHostsApi* | [**ListVirtualHosts**](docs/VirtualHostsApi.md#listvirtualhosts) | **GET** /vhosts | List VHosts


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Binding](docs/Binding.md)
 - [Model.BindingRequest](docs/BindingRequest.md)
 - [Model.BindingRequestArguments](docs/BindingRequestArguments.md)
 - [Model.ClusterName](docs/ClusterName.md)
 - [Model.ConsumeRequest](docs/ConsumeRequest.md)
 - [Model.ConsumeResponse](docs/ConsumeResponse.md)
 - [Model.Definition](docs/Definition.md)
 - [Model.ErrorMessage](docs/ErrorMessage.md)
 - [Model.Exchange](docs/Exchange.md)
 - [Model.ExchangeMessageStats](docs/ExchangeMessageStats.md)
 - [Model.ExchangeMessageStatsPublishInDetails](docs/ExchangeMessageStatsPublishInDetails.md)
 - [Model.ExchangeRequest](docs/ExchangeRequest.md)
 - [Model.InlineResponse404](docs/InlineResponse404.md)
 - [Model.MessageHeader](docs/MessageHeader.md)
 - [Model.MessageProperties](docs/MessageProperties.md)
 - [Model.Overview](docs/Overview.md)
 - [Model.OverviewChurnRates](docs/OverviewChurnRates.md)
 - [Model.OverviewContexts](docs/OverviewContexts.md)
 - [Model.OverviewExchangeTypes](docs/OverviewExchangeTypes.md)
 - [Model.OverviewListeners](docs/OverviewListeners.md)
 - [Model.OverviewMessageStats](docs/OverviewMessageStats.md)
 - [Model.OverviewObjectTotals](docs/OverviewObjectTotals.md)
 - [Model.OverviewQueueTotals](docs/OverviewQueueTotals.md)
 - [Model.OverviewSampleRetentionPolicies](docs/OverviewSampleRetentionPolicies.md)
 - [Model.OverviewSocketOpts](docs/OverviewSocketOpts.md)
 - [Model.PermissionTopic](docs/PermissionTopic.md)
 - [Model.PermissionUser](docs/PermissionUser.md)
 - [Model.PublishRequest](docs/PublishRequest.md)
 - [Model.PublishResponse](docs/PublishResponse.md)
 - [Model.Queue](docs/Queue.md)
 - [Model.QueueAction](docs/QueueAction.md)
 - [Model.QueueBackingQueueStatus](docs/QueueBackingQueueStatus.md)
 - [Model.QueueGarbageCollection](docs/QueueGarbageCollection.md)
 - [Model.QueueMessageStats](docs/QueueMessageStats.md)
 - [Model.QueueRequest](docs/QueueRequest.md)
 - [Model.User](docs/User.md)
 - [Model.UserRequest](docs/UserRequest.md)
 - [Model.VHost](docs/VHost.md)
 - [Model.VHostMessageStats](docs/VHostMessageStats.md)
 - [Model.VHostRecvOctDetails](docs/VHostRecvOctDetails.md)
 - [Model.WhoAmI](docs/WhoAmI.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="basic_auth"></a>
### basic_auth

- **Type**: HTTP basic authentication

