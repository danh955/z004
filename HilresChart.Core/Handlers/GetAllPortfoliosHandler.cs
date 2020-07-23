// <copyright file="GetAllPortfoliosHandler.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Handlers
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using HilresChart.Core.Queries;
    using HilresChart.Model.PortfolioAggregate;
    using MediatR;

    /// <summary>
    /// Get all the portfolios handler class.
    /// </summary>
    public class GetAllPortfoliosHandler : IRequestHandler<GetAllPortfoliosQuery, List<Portfolio>>
    {
        /// <inheritdoc/>
        public async Task<List<Portfolio>> Handle(GetAllPortfoliosQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(GetMockResult()).ConfigureAwait(false);
        }

        private static List<Portfolio> GetMockResult()
        {
            var portfolios = new List<Portfolio>()
            {
                new Portfolio() { Name = "Default" },
                new Portfolio() { Name = "Regular IRA" },
                new Portfolio() { Name = "Roth IRA" },
                new Portfolio() { Name = "Regular" },
            };

            return portfolios;
        }
    }
}