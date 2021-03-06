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
    /// OverviewQueueTotals
    /// </summary>
    [DataContract]
    public partial class OverviewQueueTotals :  IEquatable<OverviewQueueTotals>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverviewQueueTotals" /> class.
        /// </summary>
        /// <param name="messagesDetails">messagesDetails.</param>
        /// <param name="messagesUnacknowledgedDetails">messagesUnacknowledgedDetails.</param>
        /// <param name="messages">messages.</param>
        /// <param name="messagesReadyDetails">messagesReadyDetails.</param>
        /// <param name="messagesReady">messagesReady.</param>
        /// <param name="messagesUnacknowledged">messagesUnacknowledged.</param>
        public OverviewQueueTotals(ExchangeMessageStatsPublishInDetails messagesDetails = default(ExchangeMessageStatsPublishInDetails), ExchangeMessageStatsPublishInDetails messagesUnacknowledgedDetails = default(ExchangeMessageStatsPublishInDetails), int messages = default(int), ExchangeMessageStatsPublishInDetails messagesReadyDetails = default(ExchangeMessageStatsPublishInDetails), int messagesReady = default(int), int messagesUnacknowledged = default(int))
        {
            this.MessagesDetails = messagesDetails;
            this.MessagesUnacknowledgedDetails = messagesUnacknowledgedDetails;
            this.Messages = messages;
            this.MessagesReadyDetails = messagesReadyDetails;
            this.MessagesReady = messagesReady;
            this.MessagesUnacknowledged = messagesUnacknowledged;
        }
        
        /// <summary>
        /// Gets or Sets MessagesDetails
        /// </summary>
        [DataMember(Name="messages_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails MessagesDetails { get; set; }

        /// <summary>
        /// Gets or Sets MessagesUnacknowledgedDetails
        /// </summary>
        [DataMember(Name="messages_unacknowledged_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails MessagesUnacknowledgedDetails { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public int Messages { get; set; }

        /// <summary>
        /// Gets or Sets MessagesReadyDetails
        /// </summary>
        [DataMember(Name="messages_ready_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails MessagesReadyDetails { get; set; }

        /// <summary>
        /// Gets or Sets MessagesReady
        /// </summary>
        [DataMember(Name="messages_ready", EmitDefaultValue=false)]
        public int MessagesReady { get; set; }

        /// <summary>
        /// Gets or Sets MessagesUnacknowledged
        /// </summary>
        [DataMember(Name="messages_unacknowledged", EmitDefaultValue=false)]
        public int MessagesUnacknowledged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverviewQueueTotals {\n");
            sb.Append("  MessagesDetails: ").Append(MessagesDetails).Append("\n");
            sb.Append("  MessagesUnacknowledgedDetails: ").Append(MessagesUnacknowledgedDetails).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  MessagesReadyDetails: ").Append(MessagesReadyDetails).Append("\n");
            sb.Append("  MessagesReady: ").Append(MessagesReady).Append("\n");
            sb.Append("  MessagesUnacknowledged: ").Append(MessagesUnacknowledged).Append("\n");
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
            return this.Equals(input as OverviewQueueTotals);
        }

        /// <summary>
        /// Returns true if OverviewQueueTotals instances are equal
        /// </summary>
        /// <param name="input">Instance of OverviewQueueTotals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverviewQueueTotals input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessagesDetails == input.MessagesDetails ||
                    (this.MessagesDetails != null &&
                    this.MessagesDetails.Equals(input.MessagesDetails))
                ) && 
                (
                    this.MessagesUnacknowledgedDetails == input.MessagesUnacknowledgedDetails ||
                    (this.MessagesUnacknowledgedDetails != null &&
                    this.MessagesUnacknowledgedDetails.Equals(input.MessagesUnacknowledgedDetails))
                ) && 
                (
                    this.Messages == input.Messages ||
                    (this.Messages != null &&
                    this.Messages.Equals(input.Messages))
                ) && 
                (
                    this.MessagesReadyDetails == input.MessagesReadyDetails ||
                    (this.MessagesReadyDetails != null &&
                    this.MessagesReadyDetails.Equals(input.MessagesReadyDetails))
                ) && 
                (
                    this.MessagesReady == input.MessagesReady ||
                    (this.MessagesReady != null &&
                    this.MessagesReady.Equals(input.MessagesReady))
                ) && 
                (
                    this.MessagesUnacknowledged == input.MessagesUnacknowledged ||
                    (this.MessagesUnacknowledged != null &&
                    this.MessagesUnacknowledged.Equals(input.MessagesUnacknowledged))
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
                if (this.MessagesDetails != null)
                    hashCode = hashCode * 59 + this.MessagesDetails.GetHashCode();
                if (this.MessagesUnacknowledgedDetails != null)
                    hashCode = hashCode * 59 + this.MessagesUnacknowledgedDetails.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.MessagesReadyDetails != null)
                    hashCode = hashCode * 59 + this.MessagesReadyDetails.GetHashCode();
                if (this.MessagesReady != null)
                    hashCode = hashCode * 59 + this.MessagesReady.GetHashCode();
                if (this.MessagesUnacknowledged != null)
                    hashCode = hashCode * 59 + this.MessagesUnacknowledged.GetHashCode();
                return hashCode;
            }
        }

    }

}
