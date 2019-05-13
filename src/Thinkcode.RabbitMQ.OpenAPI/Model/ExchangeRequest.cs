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
    /// ExchangeRequest
    /// </summary>
    [DataContract]
    public partial class ExchangeRequest :  IEquatable<ExchangeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRequest" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="autoDelete">autoDelete.</param>
        /// <param name="durable">durable.</param>
        /// <param name="_internal">_internal.</param>
        /// <param name="arguments">arguments.</param>
        public ExchangeRequest(string type = default(string), bool autoDelete = default(bool), bool durable = default(bool), bool _internal = default(bool), BindingRequestArguments arguments = default(BindingRequestArguments))
        {
            this.Type = type;
            this.AutoDelete = autoDelete;
            this.Durable = durable;
            this.Internal = _internal;
            this.Arguments = arguments;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AutoDelete
        /// </summary>
        [DataMember(Name="auto_delete", EmitDefaultValue=false)]
        public bool AutoDelete { get; set; }

        /// <summary>
        /// Gets or Sets Durable
        /// </summary>
        [DataMember(Name="durable", EmitDefaultValue=false)]
        public bool Durable { get; set; }

        /// <summary>
        /// Gets or Sets Internal
        /// </summary>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public bool Internal { get; set; }

        /// <summary>
        /// Gets or Sets Arguments
        /// </summary>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public BindingRequestArguments Arguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AutoDelete: ").Append(AutoDelete).Append("\n");
            sb.Append("  Durable: ").Append(Durable).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return this.Equals(input as ExchangeRequest);
        }

        /// <summary>
        /// Returns true if ExchangeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AutoDelete == input.AutoDelete ||
                    (this.AutoDelete != null &&
                    this.AutoDelete.Equals(input.AutoDelete))
                ) && 
                (
                    this.Durable == input.Durable ||
                    (this.Durable != null &&
                    this.Durable.Equals(input.Durable))
                ) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    (this.Arguments != null &&
                    this.Arguments.Equals(input.Arguments))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AutoDelete != null)
                    hashCode = hashCode * 59 + this.AutoDelete.GetHashCode();
                if (this.Durable != null)
                    hashCode = hashCode * 59 + this.Durable.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
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