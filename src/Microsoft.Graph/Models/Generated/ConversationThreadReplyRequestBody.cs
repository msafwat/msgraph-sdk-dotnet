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
    /// The type ConversationThreadReplyRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConversationThreadReplyRequestBody
    {
    
        /// <summary>
        /// Gets or sets Post.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Post", Required = Required.Default)]
        public Post Post { get; set; }
    
    }
}
