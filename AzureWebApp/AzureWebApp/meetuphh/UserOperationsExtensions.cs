﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AzureWebApp;
using AzureWebApp.Models;
using Microsoft.Rest;

namespace AzureWebApp
{
    public static partial class UserOperationsExtensions
    {
        /// <param name='operations'>
        /// Reference to the AzureWebApp.IUserOperations.
        /// </param>
        public static IList<User> GetAllUsers(this IUserOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUserOperations)s).GetAllUsersAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureWebApp.IUserOperations.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<User>> GetAllUsersAsync(this IUserOperations operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<AzureWebApp.Models.User>> result = await operations.GetAllUsersWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureWebApp.IUserOperations.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        public static object SignupUserByUser(this IUserOperations operations, User user)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUserOperations)s).SignupUserByUserAsync(user);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureWebApp.IUserOperations.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> SignupUserByUserAsync(this IUserOperations operations, User user, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.SignupUserByUserWithOperationResponseAsync(user, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureWebApp.IUserOperations.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        public static object UpdateUserByUser(this IUserOperations operations, User user)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUserOperations)s).UpdateUserByUserAsync(user);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureWebApp.IUserOperations.
        /// </param>
        /// <param name='user'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> UpdateUserByUserAsync(this IUserOperations operations, User user, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.UpdateUserByUserWithOperationResponseAsync(user, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
