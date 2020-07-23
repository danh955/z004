// <copyright file="GetAllPortfoliosQuery.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Queries
{
    using System.Collections.Generic;
    using HilresChart.Model.PortfolioAggregate;
    using MediatR;

    /// <summary>
    /// Get list of portfolios query class.
    /// </summary>
    public class GetAllPortfoliosQuery : IRequest<List<Portfolio>>
    {
    }
}