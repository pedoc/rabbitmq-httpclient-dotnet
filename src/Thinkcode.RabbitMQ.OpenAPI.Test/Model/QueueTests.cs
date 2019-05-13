/* 
 * Rabbitmq Http API
 *
 * This is the OpenAPI specification of the RabbitMQ HTTP API. For more information, please refer to [HTTP API](https://cdn.rawgit.com/rabbitmq/rabbitmq-management/v3.7.14/priv/www/api/index.html) official documentation.
 *
 * OpenAPI spec version: 1.0
 * Contact: carlos@adaptive.me
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Model;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Thinkcode.RabbitMQ.OpenAPI.Test
{
    /// <summary>
    ///  Class for testing Queue
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QueueTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Queue
        //private Queue instance;

        public QueueTests()
        {
            // TODO uncomment below to create an instance of Queue
            //instance = new Queue();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Queue
        /// </summary>
        [Fact]
        public void QueueInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Queue
            //Assert.IsInstanceOfType<Queue> (instance, "variable 'instance' is a Queue");
        }


        /// <summary>
        /// Test the property 'Arguments'
        /// </summary>
        [Fact]
        public void ArgumentsTest()
        {
            // TODO unit test for the property 'Arguments'
        }
        /// <summary>
        /// Test the property 'AutoDelete'
        /// </summary>
        [Fact]
        public void AutoDeleteTest()
        {
            // TODO unit test for the property 'AutoDelete'
        }
        /// <summary>
        /// Test the property 'BackingQueueStatus'
        /// </summary>
        [Fact]
        public void BackingQueueStatusTest()
        {
            // TODO unit test for the property 'BackingQueueStatus'
        }
        /// <summary>
        /// Test the property 'ConsumerDetails'
        /// </summary>
        [Fact]
        public void ConsumerDetailsTest()
        {
            // TODO unit test for the property 'ConsumerDetails'
        }
        /// <summary>
        /// Test the property 'Consumers'
        /// </summary>
        [Fact]
        public void ConsumersTest()
        {
            // TODO unit test for the property 'Consumers'
        }
        /// <summary>
        /// Test the property 'Deliveries'
        /// </summary>
        [Fact]
        public void DeliveriesTest()
        {
            // TODO unit test for the property 'Deliveries'
        }
        /// <summary>
        /// Test the property 'Durable'
        /// </summary>
        [Fact]
        public void DurableTest()
        {
            // TODO unit test for the property 'Durable'
        }
        /// <summary>
        /// Test the property 'EffectivePolicyDefinition'
        /// </summary>
        [Fact]
        public void EffectivePolicyDefinitionTest()
        {
            // TODO unit test for the property 'EffectivePolicyDefinition'
        }
        /// <summary>
        /// Test the property 'Exclusive'
        /// </summary>
        [Fact]
        public void ExclusiveTest()
        {
            // TODO unit test for the property 'Exclusive'
        }
        /// <summary>
        /// Test the property 'GarbageCollection'
        /// </summary>
        [Fact]
        public void GarbageCollectionTest()
        {
            // TODO unit test for the property 'GarbageCollection'
        }
        /// <summary>
        /// Test the property 'IdleSince'
        /// </summary>
        [Fact]
        public void IdleSinceTest()
        {
            // TODO unit test for the property 'IdleSince'
        }
        /// <summary>
        /// Test the property 'Incoming'
        /// </summary>
        [Fact]
        public void IncomingTest()
        {
            // TODO unit test for the property 'Incoming'
        }
        /// <summary>
        /// Test the property 'Memory'
        /// </summary>
        [Fact]
        public void MemoryTest()
        {
            // TODO unit test for the property 'Memory'
        }
        /// <summary>
        /// Test the property 'MessageBytes'
        /// </summary>
        [Fact]
        public void MessageBytesTest()
        {
            // TODO unit test for the property 'MessageBytes'
        }
        /// <summary>
        /// Test the property 'MessageBytesPagedOut'
        /// </summary>
        [Fact]
        public void MessageBytesPagedOutTest()
        {
            // TODO unit test for the property 'MessageBytesPagedOut'
        }
        /// <summary>
        /// Test the property 'MessageBytesPersistent'
        /// </summary>
        [Fact]
        public void MessageBytesPersistentTest()
        {
            // TODO unit test for the property 'MessageBytesPersistent'
        }
        /// <summary>
        /// Test the property 'MessageBytesRam'
        /// </summary>
        [Fact]
        public void MessageBytesRamTest()
        {
            // TODO unit test for the property 'MessageBytesRam'
        }
        /// <summary>
        /// Test the property 'MessageBytesReady'
        /// </summary>
        [Fact]
        public void MessageBytesReadyTest()
        {
            // TODO unit test for the property 'MessageBytesReady'
        }
        /// <summary>
        /// Test the property 'MessageBytesUnacknowledged'
        /// </summary>
        [Fact]
        public void MessageBytesUnacknowledgedTest()
        {
            // TODO unit test for the property 'MessageBytesUnacknowledged'
        }
        /// <summary>
        /// Test the property 'MessageStats'
        /// </summary>
        [Fact]
        public void MessageStatsTest()
        {
            // TODO unit test for the property 'MessageStats'
        }
        /// <summary>
        /// Test the property 'Messages'
        /// </summary>
        [Fact]
        public void MessagesTest()
        {
            // TODO unit test for the property 'Messages'
        }
        /// <summary>
        /// Test the property 'MessagesDetails'
        /// </summary>
        [Fact]
        public void MessagesDetailsTest()
        {
            // TODO unit test for the property 'MessagesDetails'
        }
        /// <summary>
        /// Test the property 'MessagesPagedOut'
        /// </summary>
        [Fact]
        public void MessagesPagedOutTest()
        {
            // TODO unit test for the property 'MessagesPagedOut'
        }
        /// <summary>
        /// Test the property 'MessagesPersistent'
        /// </summary>
        [Fact]
        public void MessagesPersistentTest()
        {
            // TODO unit test for the property 'MessagesPersistent'
        }
        /// <summary>
        /// Test the property 'MessagesRam'
        /// </summary>
        [Fact]
        public void MessagesRamTest()
        {
            // TODO unit test for the property 'MessagesRam'
        }
        /// <summary>
        /// Test the property 'MessagesReady'
        /// </summary>
        [Fact]
        public void MessagesReadyTest()
        {
            // TODO unit test for the property 'MessagesReady'
        }
        /// <summary>
        /// Test the property 'MessagesReadyDetails'
        /// </summary>
        [Fact]
        public void MessagesReadyDetailsTest()
        {
            // TODO unit test for the property 'MessagesReadyDetails'
        }
        /// <summary>
        /// Test the property 'MessagesReadyRam'
        /// </summary>
        [Fact]
        public void MessagesReadyRamTest()
        {
            // TODO unit test for the property 'MessagesReadyRam'
        }
        /// <summary>
        /// Test the property 'MessagesUnacknowledged'
        /// </summary>
        [Fact]
        public void MessagesUnacknowledgedTest()
        {
            // TODO unit test for the property 'MessagesUnacknowledged'
        }
        /// <summary>
        /// Test the property 'MessagesUnacknowledgedDetails'
        /// </summary>
        [Fact]
        public void MessagesUnacknowledgedDetailsTest()
        {
            // TODO unit test for the property 'MessagesUnacknowledgedDetails'
        }
        /// <summary>
        /// Test the property 'MessagesUnacknowledgedRam'
        /// </summary>
        [Fact]
        public void MessagesUnacknowledgedRamTest()
        {
            // TODO unit test for the property 'MessagesUnacknowledgedRam'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Node'
        /// </summary>
        [Fact]
        public void NodeTest()
        {
            // TODO unit test for the property 'Node'
        }
        /// <summary>
        /// Test the property 'Reductions'
        /// </summary>
        [Fact]
        public void ReductionsTest()
        {
            // TODO unit test for the property 'Reductions'
        }
        /// <summary>
        /// Test the property 'ReductionsDetails'
        /// </summary>
        [Fact]
        public void ReductionsDetailsTest()
        {
            // TODO unit test for the property 'ReductionsDetails'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Vhost'
        /// </summary>
        [Fact]
        public void VhostTest()
        {
            // TODO unit test for the property 'Vhost'
        }

    }

}