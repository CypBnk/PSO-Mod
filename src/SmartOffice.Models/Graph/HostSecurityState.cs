// -----------------------------------------------------------------------
// <copyright file="HostSecurityState.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Partner.SmartOffice.Models.Graph
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class HostSecurityState
    {
        [JsonProperty]
        public string Fqdn { get; set; }

        [JsonProperty]
        public bool? IsAzureAdJoined { get; set; }

        [JsonProperty]
        public bool? IsAzureAdRegistered { get; set; }

        [JsonProperty]
        public bool? IsHybridAzureDomainJoined { get; set; }

        [JsonProperty]
        public string NetBiosName { get; set; }

        [JsonProperty]
        public string Os { get; set; }

        [JsonProperty]
        public string PrivateIpAddress { get; set; }

        [JsonProperty]
        public string PublicIpAddress { get; set; }

        [JsonProperty]
        public string RiskScore { get; set; }

        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}