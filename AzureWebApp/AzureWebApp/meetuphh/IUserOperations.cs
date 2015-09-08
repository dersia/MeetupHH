﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AzureWebApp.Models;
using Microsoft.Rest;

namespace AzureWebApp
{
    public partial interface IUserOperations
    {
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<User>>> GetAllUsersWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='user'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SignupUserByUserWithOperationResponseAsync(User user, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='user'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UpdateUserByUserWithOperationResponseAsync(User user, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
