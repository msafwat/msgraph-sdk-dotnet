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
    /// The type WorkbookFilterApplyCustomFilterRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFilterApplyCustomFilterRequestBody
    {
    
        /// <summary>
        /// Gets or sets Criteria1.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criteria1", Required = Required.Default)]
        public string Criteria1 { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criteria2", Required = Required.Default)]
        public string Criteria2 { get; set; }
    
        /// <summary>
        /// Gets or sets Oper.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oper", Required = Required.Default)]
        public string Oper { get; set; }
    
    }
}
