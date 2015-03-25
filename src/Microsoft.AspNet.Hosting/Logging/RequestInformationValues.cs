// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.Framework.Logging;

namespace Microsoft.AspNet.Hosting
{
    public class RequestInformationValues : ILogValues
    {
        public RequestInformationValues(Guid requestId)
        {
            RequestId = requestId;
        }

        public Guid RequestId { get; }

        /// <inheritdoc />
        public string Format()
        {
            return LogFormatter.FormatLogValues(this);
        }

        /// <inheritdoc />
        public IEnumerable<KeyValuePair<string, object>> GetValues()
        {
            return new[] 
            {
                new KeyValuePair<string, object>(nameof(RequestId), RequestId)
            };
        }
    }
}