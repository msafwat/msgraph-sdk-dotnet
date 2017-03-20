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
    /// The type WorkbookFunctionsNumberValueRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsNumberValueRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsNumberValueRequest>, IWorkbookFunctionsNumberValueRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsNumberValueRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="text">A text parameter for the OData method call.</param>
        /// <param name="decimalSeparator">A decimalSeparator parameter for the OData method call.</param>
        /// <param name="groupSeparator">A groupSeparator parameter for the OData method call.</param>
        public WorkbookFunctionsNumberValueRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken text,
            Newtonsoft.Json.Linq.JToken decimalSeparator,
            Newtonsoft.Json.Linq.JToken groupSeparator)
            : base(requestUrl, client)
        {
            this.SetParameter("text", text, true);
            this.SetParameter("decimalSeparator", decimalSeparator, true);
            this.SetParameter("groupSeparator", groupSeparator, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsNumberValueRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsNumberValueRequest(functionUrl, this.Client, options);

            if (this.HasParameter("text"))
            {
                request.RequestBody.Text = this.GetParameter<Newtonsoft.Json.Linq.JToken>("text");
            }

            if (this.HasParameter("decimalSeparator"))
            {
                request.RequestBody.DecimalSeparator = this.GetParameter<Newtonsoft.Json.Linq.JToken>("decimalSeparator");
            }

            if (this.HasParameter("groupSeparator"))
            {
                request.RequestBody.GroupSeparator = this.GetParameter<Newtonsoft.Json.Linq.JToken>("groupSeparator");
            }

            return request;
        }
    }
}
