// <copyright file="GetAllStocksQuery.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Queries
{
    using System.Collections.Generic;
    using HilresChart.Model;
    using MediatR;

    /// <summary>
    /// Get all stocks query.
    /// </summary>
    public class GetAllStocksQuery : IRequest<List<Stock>>
    {
    }
}