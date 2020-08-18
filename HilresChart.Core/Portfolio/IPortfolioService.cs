// <copyright file="IPortfolioService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Portfolio
{
    using System.Collections.ObjectModel;
    using HilresChart.Model.PortfolioAggregate;

    /// <summary>
    /// Portfolio service interface.
    /// </summary>
    public interface IPortfolioService
    {
        /// <summary>
        /// Gets portfolio names.
        /// </summary>
        ObservableCollection<PortfolioName> PortfolioNames { get; }

        /// <summary>
        /// Gets the current selected portfolio.
        /// </summary>
        Portfolio SelectedPortfolio { get; }

        /// <summary>
        /// Gets name of selected portfolio.
        /// </summary>
        string SelectedPortfolioName { get; }

        /// <summary>
        /// Gets list of portfolio stock items.
        /// </summary>
        ObservableCollection<PortfolioTrade> SelectedPortfolioTrades { get; }

        /// <summary>
        /// Set the selected portfolio.
        /// </summary>
        /// <param name="id">The ID of the portfolio.</param>
        void SetSelectedPortfolio(int id);
    }
}