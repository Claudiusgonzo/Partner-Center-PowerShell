// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// chatMessage
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphChatmessageallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphChatmessageallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphChatmessageallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphChatmessageallof1 class.
        /// </summary>
        /// <param name="messageType">Possible values include: 'message',
        /// 'chatEvent', 'typing'</param>
        /// <param name="importance">Possible values include: 'normal', 'high',
        /// 'urgent'</param>
        public ComponentsschemasmicrosoftGraphChatmessageallof1(string replyToId = default(string), MicrosoftgraphidentitySet fromProperty = default(MicrosoftgraphidentitySet), string etag = default(string), string messageType = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastModifiedDateTime = default(System.DateTime?), System.DateTime? deletedDateTime = default(System.DateTime?), string subject = default(string), MicrosoftgraphitemBody body = default(MicrosoftgraphitemBody), string summary = default(string), IList<MicrosoftgraphchatMessageAttachment> attachments = default(IList<MicrosoftgraphchatMessageAttachment>), IList<MicrosoftgraphchatMessageMention> mentions = default(IList<MicrosoftgraphchatMessageMention>), string importance = default(string), MicrosoftgraphchatMessagePolicyViolation policyViolation = default(MicrosoftgraphchatMessagePolicyViolation), IList<MicrosoftgraphchatMessageReaction> reactions = default(IList<MicrosoftgraphchatMessageReaction>), string locale = default(string), string webUrl = default(string), IList<MicrosoftgraphchatMessage> replies = default(IList<MicrosoftgraphchatMessage>), IList<MicrosoftgraphchatMessageHostedContent> hostedContents = default(IList<MicrosoftgraphchatMessageHostedContent>))
        {
            ReplyToId = replyToId;
            FromProperty = fromProperty;
            Etag = etag;
            MessageType = messageType;
            CreatedDateTime = createdDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
            DeletedDateTime = deletedDateTime;
            Subject = subject;
            Body = body;
            Summary = summary;
            Attachments = attachments;
            Mentions = mentions;
            Importance = importance;
            PolicyViolation = policyViolation;
            Reactions = reactions;
            Locale = locale;
            WebUrl = webUrl;
            Replies = replies;
            HostedContents = hostedContents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replyToId")]
        public string ReplyToId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public MicrosoftgraphidentitySet FromProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'message', 'chatEvent',
        /// 'typing'
        /// </summary>
        [JsonProperty(PropertyName = "messageType")]
        public string MessageType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDateTime")]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletedDateTime")]
        public System.DateTime? DeletedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public MicrosoftgraphitemBody Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachments")]
        public IList<MicrosoftgraphchatMessageAttachment> Attachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mentions")]
        public IList<MicrosoftgraphchatMessageMention> Mentions { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'normal', 'high', 'urgent'
        /// </summary>
        [JsonProperty(PropertyName = "importance")]
        public string Importance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "policyViolation")]
        public MicrosoftgraphchatMessagePolicyViolation PolicyViolation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reactions")]
        public IList<MicrosoftgraphchatMessageReaction> Reactions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replies")]
        public IList<MicrosoftgraphchatMessage> Replies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostedContents")]
        public IList<MicrosoftgraphchatMessageHostedContent> HostedContents { get; set; }

    }
}