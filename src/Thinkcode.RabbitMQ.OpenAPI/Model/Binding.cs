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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Thinkcode.RabbitMQ.OpenAPI.Client.OpenAPIDateConverter;

namespace Thinkcode.RabbitMQ.OpenAPI.Model
{
    /// <summary>
    /// Binding
    /// </summary>
    [DataContract]
    public partial class Binding :  IEquatable<Binding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Binding" /> class.
        /// </summary>
        /// <param name="arguments">arguments.</param>
        /// <param name="destination">destination.</param>
        /// <param name="destinationType">destinationType.</param>
        /// <param name="propertiesKey">propertiesKey.</param>
        /// <param name="routingKey">routingKey.</param>
        /// <param name="source">source.</param>
        /// <param name="vhost">vhost.</param>
        public Binding(BindingRequestArguments arguments = default(BindingRequestArguments), string destination = default(string), string destinationType = default(string), string propertiesKey = default(string), string routingKey = default(string), string source = default(string), string vhost = default(string))
        {
            this.Arguments = arguments;
            this.Destination = destination;
            this.DestinationType = destinationType;
            this.PropertiesKey = propertiesKey;
            this.RoutingKey = routingKey;
            this.Source = source;
            this.Vhost = vhost;
        }
        
        /// <summary>
        /// Gets or Sets Arguments
        /// </summary>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public BindingRequestArguments Arguments { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destination_type", EmitDefaultValue=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// Gets or Sets PropertiesKey
        /// </summary>
        [DataMember(Name="properties_key", EmitDefaultValue=false)]
        public string PropertiesKey { get; set; }

        /// <summary>
        /// Gets or Sets RoutingKey
        /// </summary>
        [DataMember(Name="routing_key", EmitDefaultValue=false)]
        public string RoutingKey { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Vhost
        /// </summary>
        [DataMember(Name="vhost", EmitDefaultValue=false)]
        public string Vhost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Binding {\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  PropertiesKey: ").Append(PropertiesKey).Append("\n");
            sb.Append("  RoutingKey: ").Append(RoutingKey).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Vhost: ").Append(Vhost).Append("\n");
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
            return this.Equals(input as Binding);
        }

        /// <summary>
        /// Returns true if Binding instances are equal
        /// </summary>
        /// <param name="input">Instance of Binding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Binding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arguments == input.Arguments ||
                    (this.Arguments != null &&
                    this.Arguments.Equals(input.Arguments))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.PropertiesKey == input.PropertiesKey ||
                    (this.PropertiesKey != null &&
                    this.PropertiesKey.Equals(input.PropertiesKey))
                ) && 
                (
                    this.RoutingKey == input.RoutingKey ||
                    (this.RoutingKey != null &&
                    this.RoutingKey.Equals(input.RoutingKey))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Vhost == input.Vhost ||
                    (this.Vhost != null &&
                    this.Vhost.Equals(input.Vhost))
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
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.PropertiesKey != null)
                    hashCode = hashCode * 59 + this.PropertiesKey.GetHashCode();
                if (this.RoutingKey != null)
                    hashCode = hashCode * 59 + this.RoutingKey.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Vhost != null)
                    hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
