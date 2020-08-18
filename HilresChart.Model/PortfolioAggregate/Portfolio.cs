// <copyright file="Portfolio.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Model.PortfolioAggregate
{
    using System.Collections.Generic;

    /// <summary>
    /// Portfolio class.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Items can be changed.")]
    public class Portfolio
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Portfolio"/> class.
        /// </summary>
        public Portfolio()
        {
            this.Trades = new List<PortfolioTrade>();
        }

        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of portfolio.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of portfolio trades.
        /// </summary>
        public List<PortfolioTrade> Trades { get; set; }
    }
}