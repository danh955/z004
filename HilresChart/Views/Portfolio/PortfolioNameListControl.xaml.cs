// <copyright file="PortfolioNameListControl.xaml.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Views.Portfolio
{
    using HilresChart.Core.Portfolio;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Portfolio name list control class.
    /// </summary>
    public sealed partial class PortfolioNameListControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioNameListControl"/> class.
        /// </summary>
        public PortfolioNameListControl()
        {
            this.PortfolioService = App.CoreService.GetService<IPortfolioService>();
            this.InitializeComponent();
            this.PortfolioNameDataGrid.SelectionChanged += this.PortfolioNameDataGrid_SelectionChanged;
        }

        /// <summary>
        /// Gets portfolio service.
        /// </summary>
        internal IPortfolioService PortfolioService { get; private set; }

        private void PortfolioNameDataGrid_SelectionChanged(object sender, Telerik.UI.Xaml.Controls.Grid.DataGridSelectionChangedEventArgs e)
        {
            RadDataGrid dataGrid = (RadDataGrid)sender;
            PortfolioName item = (PortfolioName)dataGrid.SelectedItem;
            this.PortfolioService.SetSelectedPortfolio(item.Id);
        }
    }
}