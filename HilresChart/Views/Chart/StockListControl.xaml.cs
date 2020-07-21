// <copyright file="StockListControl.xaml.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Views.Chart
{
    using HilresChart.Core;
    using HilresChart.Core.Queries;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Stock list control class.
    /// </summary>
    public sealed partial class StockListControl : UserControl
    {
        private readonly ICoreService coreService;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockListControl"/> class.
        /// </summary>
        public StockListControl()
        {
            this.InitializeComponent();
            this.coreService = App.GetCoreService();
            //// var query = new GetAllStocksQuery();
            var query = new GetAllPortfoliosQuery();
            this.DataGrid.ItemsSource = this.coreService.SendAsync(query).Result;
        }
    }
}