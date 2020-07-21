// <copyright file="ICoreService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    /// <summary>
    /// Core service interface.
    /// </summary>
    public interface ICoreService
    {
        /// <summary>
        /// Send a request.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="request">The request type.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);
    }
}