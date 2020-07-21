// <copyright file="PortfolioItem.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Model.PortfolioAggregate
{
    using System;

    /// <summary>
    /// Portfolio class.
    /// </summary>
    public class PortfolioItem
    {
        /// <summary>
        /// Gets or sets symbol.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets long name of the stock.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets action.
        /// </summary>
        public Action Action { get; set; }

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets entry date.
        /// </summary>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// Gets or sets entry price.
        /// </summary>
        public decimal EntryPrice { get; set; }

        /// <summary>
        /// Gets or sets exit date.
        /// </summary>
        public DateTime ExitDate { get; set; }

        /// <summary>
        /// Gets or sets exit price.
        /// </summary>
        public decimal ExitPrice { get; set; }
    }
}