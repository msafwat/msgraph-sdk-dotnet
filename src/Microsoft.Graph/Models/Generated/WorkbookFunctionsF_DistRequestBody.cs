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
    /// The type WorkbookFunctionsF_DistRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsF_DistRequestBody
    {
    
        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "x", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken X { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom1.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "degFreedom1", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken DegFreedom1 { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "degFreedom2", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken DegFreedom2 { get; set; }
    
        /// <summary>
        /// Gets or sets Cumulative.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cumulative", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Cumulative { get; set; }
    
    }
}
