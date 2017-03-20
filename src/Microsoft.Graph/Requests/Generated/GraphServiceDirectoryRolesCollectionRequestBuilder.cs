// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceDirectoryRolesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceDirectoryRolesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceDirectoryRolesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceDirectoryRolesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceDirectoryRolesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceDirectoryRolesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceDirectoryRolesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceDirectoryRolesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryRoleRequestBuilder"/> for the specified GraphServiceDirectoryRole.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceDirectoryRole.</param>
        /// <returns>The <see cref="IDirectoryRoleRequestBuilder"/>.</returns>
        public IDirectoryRoleRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryRoleRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
