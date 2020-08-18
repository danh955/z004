// <copyright file="StockListControl.xaml.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Views.Chart
{
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Stock list control class.
    /// </summary>
    public sealed partial class StockListControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockListControl"/> class.
        /// </summary>
        public StockListControl()
        {
            this.InitializeComponent();
            ////var coreService = App.GetCoreService();
            ////var loadStocks = coreService.SendAsync(new GetAllStocksQuery()).Result;
            ////this.Stocks = new ObservableCollection<Stock>(loadStocks);
            ////this.DataGrid.ItemsSource = this.Stocks;
        }

        ////private ObservableCollection<Stock> Stocks { get; set; }
    }
}