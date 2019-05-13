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
    /// VHost
    /// </summary>
    [DataContract]
    public partial class VHost :  IEquatable<VHost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VHost" /> class.
        /// </summary>
        /// <param name="messageStats">messageStats.</param>
        /// <param name="messages">messages.</param>
        /// <param name="messagesDetails">messagesDetails.</param>
        /// <param name="messagesReady">messagesReady.</param>
        /// <param name="messagesReadyDetails">messagesReadyDetails.</param>
        /// <param name="messagesUnacknowledged">messagesUnacknowledged.</param>
        /// <param name="messagesUnacknowledgedDetails">messagesUnacknowledgedDetails.</param>
        /// <param name="name">name.</param>
        /// <param name="recvOct">recvOct.</param>
        /// <param name="recvOctDetails">recvOctDetails.</param>
        /// <param name="sendOct">sendOct.</param>
        /// <param name="sendOctDetails">sendOctDetails.</param>
        /// <param name="tracing">tracing.</param>
        public VHost(VHostMessageStats messageStats = default(VHostMessageStats), int messages = default(int), ExchangeMessageStatsPublishInDetails messagesDetails = default(ExchangeMessageStatsPublishInDetails), int messagesReady = default(int), ExchangeMessageStatsPublishInDetails messagesReadyDetails = default(ExchangeMessageStatsPublishInDetails), int messagesUnacknowledged = default(int), ExchangeMessageStatsPublishInDetails messagesUnacknowledgedDetails = default(ExchangeMessageStatsPublishInDetails), string name = default(string), int recvOct = default(int), VHostRecvOctDetails recvOctDetails = default(VHostRecvOctDetails), int sendOct = default(int), VHostRecvOctDetails sendOctDetails = default(VHostRecvOctDetails), bool tracing = default(bool))
        {
            this.MessageStats = messageStats;
            this.Messages = messages;
            this.MessagesDetails = messagesDetails;
            this.MessagesReady = messagesReady;
            this.MessagesReadyDetails = messagesReadyDetails;
            this.MessagesUnacknowledged = messagesUnacknowledged;
            this.MessagesUnacknowledgedDetails = messagesUnacknowledgedDetails;
            this.Name = name;
            this.RecvOct = recvOct;
            this.RecvOctDetails = recvOctDetails;
            this.SendOct = sendOct;
            this.SendOctDetails = sendOctDetails;
            this.Tracing = tracing;
        }
        
        /// <summary>
        /// Gets or Sets MessageStats
        /// </summary>
        [DataMember(Name="message_stats", EmitDefaultValue=false)]
        public VHostMessageStats MessageStats { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public int Messages { get; set; }

        /// <summary>
        /// Gets or Sets MessagesDetails
        /// </summary>
        [DataMember(Name="messages_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails MessagesDetails { get; set; }

        /// <summary>
        /// Gets or Sets MessagesReady
        /// </summary>
        [DataMember(Name="messages_ready", EmitDefaultValue=false)]
        public int MessagesReady { get; set; }

        /// <summary>
        /// Gets or Sets MessagesReadyDetails
        /// </summary>
        [DataMember(Name="messages_ready_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails MessagesReadyDetails { get; set; }

        /// <summary>
        /// Gets or Sets MessagesUnacknowledged
        /// </summary>
        [DataMember(Name="messages_unacknowledged", EmitDefaultValue=false)]
        public int MessagesUnacknowledged { get; set; }

        /// <summary>
        /// Gets or Sets MessagesUnacknowledgedDetails
        /// </summary>
        [DataMember(Name="messages_unacknowledged_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails MessagesUnacknowledgedDetails { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RecvOct
        /// </summary>
        [DataMember(Name="recv_oct", EmitDefaultValue=false)]
        public int RecvOct { get; set; }

        /// <summary>
        /// Gets or Sets RecvOctDetails
        /// </summary>
        [DataMember(Name="recv_oct_details", EmitDefaultValue=false)]
        public VHostRecvOctDetails RecvOctDetails { get; set; }

        /// <summary>
        /// Gets or Sets SendOct
        /// </summary>
        [DataMember(Name="send_oct", EmitDefaultValue=false)]
        public int SendOct { get; set; }

        /// <summary>
        /// Gets or Sets SendOctDetails
        /// </summary>
        [DataMember(Name="send_oct_details", EmitDefaultValue=false)]
        public VHostRecvOctDetails SendOctDetails { get; set; }

        /// <summary>
        /// Gets or Sets Tracing
        /// </summary>
        [DataMember(Name="tracing", EmitDefaultValue=false)]
        public bool Tracing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VHost {\n");
            sb.Append("  MessageStats: ").Append(MessageStats).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  MessagesDetails: ").Append(MessagesDetails).Append("\n");
            sb.Append("  MessagesReady: ").Append(MessagesReady).Append("\n");
            sb.Append("  MessagesReadyDetails: ").Append(MessagesReadyDetails).Append("\n");
            sb.Append("  MessagesUnacknowledged: ").Append(MessagesUnacknowledged).Append("\n");
            sb.Append("  MessagesUnacknowledgedDetails: ").Append(MessagesUnacknowledgedDetails).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecvOct: ").Append(RecvOct).Append("\n");
            sb.Append("  RecvOctDetails: ").Append(RecvOctDetails).Append("\n");
            sb.Append("  SendOct: ").Append(SendOct).Append("\n");
            sb.Append("  SendOctDetails: ").Append(SendOctDetails).Append("\n");
            sb.Append("  Tracing: ").Append(Tracing).Append("\n");
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
            return this.Equals(input as VHost);
        }

        /// <summary>
        /// Returns true if VHost instances are equal
        /// </summary>
        /// <param name="input">Instance of VHost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VHost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageStats == input.MessageStats ||
                    (this.MessageStats != null &&
                    this.MessageStats.Equals(input.MessageStats))
                ) && 
                (
                    this.Messages == input.Messages ||
                    (this.Messages != null &&
                    this.Messages.Equals(input.Messages))
                ) && 
                (
                    this.MessagesDetails == input.MessagesDetails ||
                    (this.MessagesDetails != null &&
                    this.MessagesDetails.Equals(input.MessagesDetails))
                ) && 
                (
                    this.MessagesReady == input.MessagesReady ||
                    (this.MessagesReady != null &&
                    this.MessagesReady.Equals(input.MessagesReady))
                ) && 
                (
                    this.MessagesReadyDetails == input.MessagesReadyDetails ||
                    (this.MessagesReadyDetails != null &&
                    this.MessagesReadyDetails.Equals(input.MessagesReadyDetails))
                ) && 
                (
                    this.MessagesUnacknowledged == input.MessagesUnacknowledged ||
                    (this.MessagesUnacknowledged != null &&
                    this.MessagesUnacknowledged.Equals(input.MessagesUnacknowledged))
                ) && 
                (
                    this.MessagesUnacknowledgedDetails == input.MessagesUnacknowledgedDetails ||
                    (this.MessagesUnacknowledgedDetails != null &&
                    this.MessagesUnacknowledgedDetails.Equals(input.MessagesUnacknowledgedDetails))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RecvOct == input.RecvOct ||
                    (this.RecvOct != null &&
                    this.RecvOct.Equals(input.RecvOct))
                ) && 
                (
                    this.RecvOctDetails == input.RecvOctDetails ||
                    (this.RecvOctDetails != null &&
                    this.RecvOctDetails.Equals(input.RecvOctDetails))
                ) && 
                (
                    this.SendOct == input.SendOct ||
                    (this.SendOct != null &&
                    this.SendOct.Equals(input.SendOct))
                ) && 
                (
                    this.SendOctDetails == input.SendOctDetails ||
                    (this.SendOctDetails != null &&
                    this.SendOctDetails.Equals(input.SendOctDetails))
                ) && 
                (
                    this.Tracing == input.Tracing ||
                    (this.Tracing != null &&
                    this.Tracing.Equals(input.Tracing))
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
                if (this.MessageStats != null)
                    hashCode = hashCode * 59 + this.MessageStats.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.MessagesDetails != null)
                    hashCode = hashCode * 59 + this.MessagesDetails.GetHashCode();
                if (this.MessagesReady != null)
                    hashCode = hashCode * 59 + this.MessagesReady.GetHashCode();
                if (this.MessagesReadyDetails != null)
                    hashCode = hashCode * 59 + this.MessagesReadyDetails.GetHashCode();
                if (this.MessagesUnacknowledged != null)
                    hashCode = hashCode * 59 + this.MessagesUnacknowledged.GetHashCode();
                if (this.MessagesUnacknowledgedDetails != null)
                    hashCode = hashCode * 59 + this.MessagesUnacknowledgedDetails.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecvOct != null)
                    hashCode = hashCode * 59 + this.RecvOct.GetHashCode();
                if (this.RecvOctDetails != null)
                    hashCode = hashCode * 59 + this.RecvOctDetails.GetHashCode();
                if (this.SendOct != null)
                    hashCode = hashCode * 59 + this.SendOct.GetHashCode();
                if (this.SendOctDetails != null)
                    hashCode = hashCode * 59 + this.SendOctDetails.GetHashCode();
                if (this.Tracing != null)
                    hashCode = hashCode * 59 + this.Tracing.GetHashCode();
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
