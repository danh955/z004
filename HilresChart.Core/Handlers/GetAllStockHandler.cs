// <copyright file="GetAllStockHandler.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Handlers
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using HilresChart.Core.Queries;
    using HilresChart.Model;
    using MediatR;

    /// <summary>
    /// Get all the stock handler class.
    /// </summary>
    internal class GetAllStockHandler : IRequestHandler<GetAllStocksQuery, List<Stock>>
    {
        /// <inheritdoc/>
        public async Task<List<Stock>> Handle(GetAllStocksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(GetMockResult()).ConfigureAwait(false);
        }

        private static List<Stock> GetMockResult()
        {
            var stocks = new List<Stock>();

            for (int i = 1; i < 30; i++)
            {
                stocks.Add(new Stock { Id = i, Symbol = i.ToString(CultureInfo.InvariantCulture) });
            }

            return stocks;
        }
    }
}