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
    using System.Linq;

    /// <summary>
    /// sharingInvitation
    /// </summary>
    public partial class MicrosoftgraphsharingInvitation
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphsharingInvitation
        /// class.
        /// </summary>
        public MicrosoftgraphsharingInvitation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphsharingInvitation
        /// class.
        /// </summary>
        public MicrosoftgraphsharingInvitation(string email = default(string), MicrosoftgraphidentitySet invitedBy = default(MicrosoftgraphidentitySet), string redeemedBy = default(string), bool? signInRequired = default(bool?))
        {
            Email = email;
            InvitedBy = invitedBy;
            RedeemedBy = redeemedBy;
            SignInRequired = signInRequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invitedBy")]
        public MicrosoftgraphidentitySet InvitedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "redeemedBy")]
        public string RedeemedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signInRequired")]
        public bool? SignInRequired { get; set; }

    }
}