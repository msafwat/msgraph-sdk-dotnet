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
    /// The type WorkbookFunctionsPercentile_ExcRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsPercentile_ExcRequestBody
    {
    
        /// <summary>
        /// Gets or sets Array.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "array", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Array { get; set; }
    
        /// <summary>
        /// Gets or sets K.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "k", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken K { get; set; }
    
    }
}
