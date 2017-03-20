// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GroupThreadsCollectionRequestBuilder.
    /// </summary>
    public partial class GroupThreadsCollectionRequestBuilder : BaseRequestBuilder, IGroupThreadsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GroupThreadsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupThreadsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupThreadsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupThreadsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GroupThreadsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConversationThreadRequestBuilder"/> for the specified GroupConversationThread.
        /// </summary>
        /// <param name="id">The ID for the GroupConversationThread.</param>
        /// <returns>The <see cref="IConversationThreadRequestBuilder"/>.</returns>
        public IConversationThreadRequestBuilder this[string id]
        {
            get
            {
                return new ConversationThreadRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
