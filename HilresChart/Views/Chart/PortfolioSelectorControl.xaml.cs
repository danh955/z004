// <copyright file="PortfolioSelectorControl.xaml.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Views.Chart
{
    using System.Collections.ObjectModel;
    using HilresChart.Core.Queries;
    using HilresChart.Model.PortfolioAggregate;
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
            this.InitializeComponent();
            var coreService = App.GetCoreService();
            var loadPortfolios = coreService.SendAsync(new GetAllPortfoliosQuery()).Result;
            this.Portfolios = new ObservableCollection<Portfolio>(loadPortfolios);
            this.PortfolioSelector.ItemsSource = this.Portfolios;
            this.PortfolioSelector.SelectedIndex = 0;
        }

        /// <summary>
        /// Gets list of Portfolios.
        /// </summary>
        internal ObservableCollection<Portfolio> Portfolios { get; private set; }
    }
}