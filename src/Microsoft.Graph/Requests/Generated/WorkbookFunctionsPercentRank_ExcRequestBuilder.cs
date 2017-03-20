// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsPercentRank_ExcRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsPercentRank_ExcRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsPercentRank_ExcRequest>, IWorkbookFunctionsPercentRank_ExcRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsPercentRank_ExcRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="array">A array parameter for the OData method call.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="significance">A significance parameter for the OData method call.</param>
        public WorkbookFunctionsPercentRank_ExcRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken array,
            Newtonsoft.Json.Linq.JToken x,
            Newtonsoft.Json.Linq.JToken significance)
            : base(requestUrl, client)
        {
            this.SetParameter("array", array, true);
            this.SetParameter("x", x, true);
            this.SetParameter("significance", significance, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsPercentRank_ExcRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsPercentRank_ExcRequest(functionUrl, this.Client, options);

            if (this.HasParameter("array"))
            {
                request.RequestBody.Array = this.GetParameter<Newtonsoft.Json.Linq.JToken>("array");
            }

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<Newtonsoft.Json.Linq.JToken>("x");
            }

            if (this.HasParameter("significance"))
            {
                request.RequestBody.Significance = this.GetParameter<Newtonsoft.Json.Linq.JToken>("significance");
            }

            return request;
        }
    }
}
