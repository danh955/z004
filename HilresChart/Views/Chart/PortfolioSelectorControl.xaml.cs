// <copyright file="PortfolioSelectorControl.xaml.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Views.Chart
{
    using HilresChart.Core.Portfolio;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Portfolio selector user control class.
    /// </summary>
    public sealed partial class PortfolioSelectorControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioSelectorControl"/> class.
        /// </summary>
        public PortfolioSelectorControl()
        {
            this.PortfolioService = App.CoreService.GetService<IPortfolioService>();
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets portfolio service.
        /// </summary>
        internal IPortfolioService PortfolioService { get; private set; }
    }
}