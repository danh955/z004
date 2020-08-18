// <copyright file="ICoreService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core
{
    /// <summary>
    /// Core service interface.
    /// </summary>
    public interface ICoreService
    {
        /// <summary>
        /// Get a service.
        /// </summary>
        /// <typeparam name="TResponse">Service to get.</typeparam>
        /// <returns>The service.</returns>
        TResponse GetService<TResponse>();
    }
}