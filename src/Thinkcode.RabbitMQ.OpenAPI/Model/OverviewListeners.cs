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
    /// OverviewListeners
    /// </summary>
    [DataContract]
    public partial class OverviewListeners :  IEquatable<OverviewListeners>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverviewListeners" /> class.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="socketOpts">socketOpts.</param>
        /// <param name="port">port.</param>
        /// <param name="ipAddress">ipAddress.</param>
        public OverviewListeners(string node = default(string), string protocol = default(string), OverviewSocketOpts socketOpts = default(OverviewSocketOpts), int port = default(int), string ipAddress = default(string))
        {
            this.Node = node;
            this.Protocol = protocol;
            this.SocketOpts = socketOpts;
            this.Port = port;
            this.IpAddress = ipAddress;
        }
        
        /// <summary>
        /// Gets or Sets Node
        /// </summary>
        [DataMember(Name="node", EmitDefaultValue=false)]
        public string Node { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or Sets SocketOpts
        /// </summary>
        [DataMember(Name="socket_opts", EmitDefaultValue=false)]
        public OverviewSocketOpts SocketOpts { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ip_address", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverviewListeners {\n");
            sb.Append("  Node: ").Append(Node).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  SocketOpts: ").Append(SocketOpts).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
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
            return this.Equals(input as OverviewListeners);
        }

        /// <summary>
        /// Returns true if OverviewListeners instances are equal
        /// </summary>
        /// <param name="input">Instance of OverviewListeners to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverviewListeners input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Node == input.Node ||
                    (this.Node != null &&
                    this.Node.Equals(input.Node))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.SocketOpts == input.SocketOpts ||
                    (this.SocketOpts != null &&
                    this.SocketOpts.Equals(input.SocketOpts))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
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
                if (this.Node != null)
                    hashCode = hashCode * 59 + this.Node.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SocketOpts != null)
                    hashCode = hashCode * 59 + this.SocketOpts.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                return hashCode;
            }
        }

    }

}
