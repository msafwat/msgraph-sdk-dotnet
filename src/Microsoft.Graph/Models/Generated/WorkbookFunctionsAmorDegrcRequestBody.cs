// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsAmorDegrcRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsAmorDegrcRequestBody
    {
    
        /// <summary>
        /// Gets or sets Cost.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cost", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Cost { get; set; }
    
        /// <summary>
        /// Gets or sets DatePurchased.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "datePurchased", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken DatePurchased { get; set; }
    
        /// <summary>
        /// Gets or sets FirstPeriod.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firstPeriod", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken FirstPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets Salvage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salvage", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Salvage { get; set; }
    
        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "period", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Period { get; set; }
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rate", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "basis", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Basis { get; set; }
    
    }
}
