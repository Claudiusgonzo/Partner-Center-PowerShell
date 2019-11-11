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

    public partial class Microsoftgraphprofile
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphprofile class.
        /// </summary>
        public Microsoftgraphprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphprofile class.
        /// </summary>
        public Microsoftgraphprofile(string id = default(string), IList<MicrosoftgraphuserAccountInformation> account = default(IList<MicrosoftgraphuserAccountInformation>), IList<MicrosoftgraphpersonAnniversary> anniversaries = default(IList<MicrosoftgraphpersonAnniversary>), IList<MicrosoftgrapheducationalActivity> educationalActivities = default(IList<MicrosoftgrapheducationalActivity>), IList<MicrosoftgraphitemEmail> emails = default(IList<MicrosoftgraphitemEmail>), IList<MicrosoftgraphpersonInterest> interests = default(IList<MicrosoftgraphpersonInterest>), IList<MicrosoftgraphlanguageProficiency> languages = default(IList<MicrosoftgraphlanguageProficiency>), IList<MicrosoftgraphpersonName> names = default(IList<MicrosoftgraphpersonName>), IList<MicrosoftgraphitemPhone> phones = default(IList<MicrosoftgraphitemPhone>), IList<MicrosoftgraphworkPosition> positions = default(IList<MicrosoftgraphworkPosition>), IList<MicrosoftgraphprojectParticipation> projects = default(IList<MicrosoftgraphprojectParticipation>), IList<MicrosoftgraphskillProficiency> skills = default(IList<MicrosoftgraphskillProficiency>), IList<MicrosoftgraphwebAccount> webAccounts = default(IList<MicrosoftgraphwebAccount>), IList<MicrosoftgraphpersonWebsite> websites = default(IList<MicrosoftgraphpersonWebsite>))
        {
            Id = id;
            Account = account;
            Anniversaries = anniversaries;
            EducationalActivities = educationalActivities;
            Emails = emails;
            Interests = interests;
            Languages = languages;
            Names = names;
            Phones = phones;
            Positions = positions;
            Projects = projects;
            Skills = skills;
            WebAccounts = webAccounts;
            Websites = websites;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public IList<MicrosoftgraphuserAccountInformation> Account { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "anniversaries")]
        public IList<MicrosoftgraphpersonAnniversary> Anniversaries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "educationalActivities")]
        public IList<MicrosoftgrapheducationalActivity> EducationalActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emails")]
        public IList<MicrosoftgraphitemEmail> Emails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interests")]
        public IList<MicrosoftgraphpersonInterest> Interests { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languages")]
        public IList<MicrosoftgraphlanguageProficiency> Languages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<MicrosoftgraphpersonName> Names { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phones")]
        public IList<MicrosoftgraphitemPhone> Phones { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "positions")]
        public IList<MicrosoftgraphworkPosition> Positions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "projects")]
        public IList<MicrosoftgraphprojectParticipation> Projects { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skills")]
        public IList<MicrosoftgraphskillProficiency> Skills { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webAccounts")]
        public IList<MicrosoftgraphwebAccount> WebAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "websites")]
        public IList<MicrosoftgraphpersonWebsite> Websites { get; set; }

    }
}