// <copyright file="CoreService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
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
                .AddMediatR(this.GetType().Assembly);

            this.Container = container.BuildServiceProvider();
            this.Mediator = this.Container.GetRequiredService<IMediator>();
        }

        /// <summary>
        /// Gets container.
        /// </summary>
        internal ServiceProvider Container { get; private set; }

        /// <summary>
        /// Gets mediator.
        /// </summary>
        internal IMediator Mediator { get; private set; }

        /// <inheritdoc/>
        public async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            return await this.Mediator.Send(request, cancellationToken).ConfigureAwait(false);
        }
    }
}