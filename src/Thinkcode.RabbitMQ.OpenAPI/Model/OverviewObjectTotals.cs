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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Thinkcode.RabbitMQ.OpenAPI.Client.OpenAPIDateConverter;

namespace Thinkcode.RabbitMQ.OpenAPI.Model
{
    /// <summary>
    /// OverviewObjectTotals
    /// </summary>
    [DataContract]
    public partial class OverviewObjectTotals :  IEquatable<OverviewObjectTotals>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverviewObjectTotals" /> class.
        /// </summary>
        /// <param name="channels">channels.</param>
        /// <param name="queues">queues.</param>
        /// <param name="exchanges">exchanges.</param>
        /// <param name="consumers">consumers.</param>
        /// <param name="connections">connections.</param>
        public OverviewObjectTotals(int channels = default(int), int queues = default(int), int exchanges = default(int), int consumers = default(int), int connections = default(int))
        {
            this.Channels = channels;
            this.Queues = queues;
            this.Exchanges = exchanges;
            this.Consumers = consumers;
            this.Connections = connections;
        }
        
        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public int Channels { get; set; }

        /// <summary>
        /// Gets or Sets Queues
        /// </summary>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public int Queues { get; set; }

        /// <summary>
        /// Gets or Sets Exchanges
        /// </summary>
        [DataMember(Name="exchanges", EmitDefaultValue=false)]
        public int Exchanges { get; set; }

        /// <summary>
        /// Gets or Sets Consumers
        /// </summary>
        [DataMember(Name="consumers", EmitDefaultValue=false)]
        public int Consumers { get; set; }

        /// <summary>
        /// Gets or Sets Connections
        /// </summary>
        [DataMember(Name="connections", EmitDefaultValue=false)]
        public int Connections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverviewObjectTotals {\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  Exchanges: ").Append(Exchanges).Append("\n");
            sb.Append("  Consumers: ").Append(Consumers).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OverviewObjectTotals);
        }

        /// <summary>
        /// Returns true if OverviewObjectTotals instances are equal
        /// </summary>
        /// <param name="input">Instance of OverviewObjectTotals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverviewObjectTotals input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Channels == input.Channels ||
                    (this.Channels != null &&
                    this.Channels.Equals(input.Channels))
                ) && 
                (
                    this.Queues == input.Queues ||
                    (this.Queues != null &&
                    this.Queues.Equals(input.Queues))
                ) && 
                (
                    this.Exchanges == input.Exchanges ||
                    (this.Exchanges != null &&
                    this.Exchanges.Equals(input.Exchanges))
                ) && 
                (
                    this.Consumers == input.Consumers ||
                    (this.Consumers != null &&
                    this.Consumers.Equals(input.Consumers))
                ) && 
                (
                    this.Connections == input.Connections ||
                    (this.Connections != null &&
                    this.Connections.Equals(input.Connections))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.Queues != null)
                    hashCode = hashCode * 59 + this.Queues.GetHashCode();
                if (this.Exchanges != null)
                    hashCode = hashCode * 59 + this.Exchanges.GetHashCode();
                if (this.Consumers != null)
                    hashCode = hashCode * 59 + this.Consumers.GetHashCode();
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                return hashCode;
            }
        }

    }

}
