﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace AzureWebApp
{
    public partial interface IMail
    {
        /// <param name='message'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SendMailByMessageWithOperationResponseAsync(string message, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
