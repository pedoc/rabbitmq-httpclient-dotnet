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
    ///  Class for testing PubSubApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PubSubApiTests : IDisposable
    {
        private PubSubApi instance;

        public PubSubApiTests()
        {
            instance = new PubSubApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PubSubApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PubSubApi
            //Assert.IsType(typeof(PubSubApi), instance, "instance is a PubSubApi");
        }

        
        /// <summary>
        /// Test ConsumeMessage
        /// </summary>
        [Fact]
        public void ConsumeMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //ConsumeRequest body = null;
            //var response = instance.ConsumeMessage(vhost, queue, body);
            //Assert.IsType<ICollection<ConsumeResponse>> (response, "response is ICollection<ConsumeResponse>");
        }
        
        /// <summary>
        /// Test PublishMessage
        /// </summary>
        [Fact]
        public void PublishMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string exchange = null;
            //PublishRequest body = null;
            //var response = instance.PublishMessage(vhost, exchange, body);
            //Assert.IsType<PublishResponse> (response, "response is PublishResponse");
        }
        
    }

}
