// <copyright file="PortfolioService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Portfolio
{
    using System;
    using System.Collections.ObjectModel;
    using HilresChart.Model.PortfolioAggregate;

    /// <summary>
    /// Portfolio service class.
    /// </summary>
    internal class PortfolioService : IPortfolioService
    {
        private readonly Lazy<PortfolioNameObservableCollection> portfolioNameLazy =
            new Lazy<PortfolioNameObservableCollection>(
            () => { return new PortfolioNameObservableCollection(); });

        /// <inheritdoc/>
        public ObservableCollection<PortfolioName> PortfolioNames => this.portfolioNameLazy.Value;

        /// <inheritdoc/>
        public Portfolio SelectedPortfolio { get; internal set; }

        /// <inheritdoc/>
        public ObservableCollection<PortfolioTrade> SelectedPortfolioTrades { get; private set; }

        /// <inheritdoc/>
        public string SelectedPortfolioName { get; private set; }

        /// <inheritdoc/>
        public void SetSelectedPortfolio(int id)
        {
            Portfolio selectedItem;

            //// TODO: call database.
            switch (id)
            {
                case 1:
                    {
                        selectedItem = new Portfolio()
                        {
                            Id = 1,
                            Name = "Default",
                        };
                        break;
                    }

                case 2:
                    {
                        selectedItem = new Portfolio()
                        {
                            Id = 2,
                            Name = "Other",
                        };
                        break;
                    }

                default:
                    selectedItem = null;
                    break;
            }

            this.SelectedPortfolio = selectedItem;
            this.SelectedPortfolioName = selectedItem?.Name;
            this.SelectedPortfolioTrades = new ObservableCollection<PortfolioTrade>(selectedItem?.Trades);
        }
    }
}