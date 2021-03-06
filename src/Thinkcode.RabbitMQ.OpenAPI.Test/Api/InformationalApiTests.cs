/* 
 * Rabbitmq Http API
 *
 * This is the OpenAPI specification of the RabbitMQ HTTP API. For more information, please refer to [HTTP API](https://cdn.rawgit.com/rabbitmq/rabbitmq-management/v3.7.14/priv/www/api/index.html) official documentation.
 *
 * OpenAPI spec version: 1.0
 * Contact: carlos@adaptive.me
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Thinkcode.RabbitMQ.OpenAPI.Test
{
    /// <summary>
    ///  Class for testing InformationalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InformationalApiTests : IDisposable
    {
        private InformationalApi instance;

        public InformationalApiTests()
        {
            instance = new InformationalApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InformationalApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InformationalApi
            //Assert.IsType(typeof(InformationalApi), instance, "instance is a InformationalApi");
        }

        
        /// <summary>
        /// Test GetClusterName
        /// </summary>
        [Fact]
        public void GetClusterNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetClusterName();
            //Assert.IsType<ClusterName> (response, "response is ClusterName");
        }
        
        /// <summary>
        /// Test GetDefinitionsForVirtualHost
        /// </summary>
        [Fact]
        public void GetDefinitionsForVirtualHostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //var response = instance.GetDefinitionsForVirtualHost(vhost);
            //Assert.IsType<Definition> (response, "response is Definition");
        }
        
        /// <summary>
        /// Test GetOverview
        /// </summary>
        [Fact]
        public void GetOverviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetOverview();
            //Assert.IsType<Overview> (response, "response is Overview");
        }
        
        /// <summary>
        /// Test ListDefinitions
        /// </summary>
        [Fact]
        public void ListDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListDefinitions();
            //Assert.IsType<Definition> (response, "response is Definition");
        }
        
    }

}
