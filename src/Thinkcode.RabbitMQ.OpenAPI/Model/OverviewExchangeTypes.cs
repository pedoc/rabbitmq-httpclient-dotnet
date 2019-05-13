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
    /// OverviewExchangeTypes
    /// </summary>
    [DataContract]
    public partial class OverviewExchangeTypes :  IEquatable<OverviewExchangeTypes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverviewExchangeTypes" /> class.
        /// </summary>
        /// <param name="internalPurpose">internalPurpose.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="enabled">enabled.</param>
        public OverviewExchangeTypes(string internalPurpose = default(string), string name = default(string), string description = default(string), bool enabled = default(bool))
        {
            this.InternalPurpose = internalPurpose;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
        }
        
        /// <summary>
        /// Gets or Sets InternalPurpose
        /// </summary>
        [DataMember(Name="internal_purpose", EmitDefaultValue=false)]
        public string InternalPurpose { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverviewExchangeTypes {\n");
            sb.Append("  InternalPurpose: ").Append(InternalPurpose).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as OverviewExchangeTypes);
        }

        /// <summary>
        /// Returns true if OverviewExchangeTypes instances are equal
        /// </summary>
        /// <param name="input">Instance of OverviewExchangeTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverviewExchangeTypes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternalPurpose == input.InternalPurpose ||
                    (this.InternalPurpose != null &&
                    this.InternalPurpose.Equals(input.InternalPurpose))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.InternalPurpose != null)
                    hashCode = hashCode * 59 + this.InternalPurpose.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }

    }

}
