// <copyright file="CoreService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core
{
    using HilresChart.Core.Portfolio;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Core service class.
    /// </summary>
    public class CoreService : ICoreService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreService"/> class.
        /// </summary>
        public CoreService()
        {
            var container = new ServiceCollection()
                .AddSingleton<IPortfolioService>(new PortfolioService());

            this.Container = container.BuildServiceProvider();
        }

        /// <summary>
        /// Gets container.
        /// </summary>
        internal ServiceProvider Container { get; private set; }

        /// <inheritdoc/>
        public TResponse GetService<TResponse>()
        {
            return this.Container.GetService<TResponse>();
        }
    }
}