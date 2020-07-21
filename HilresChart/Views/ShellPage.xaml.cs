// <copyright file="ShellPage.xaml.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Views
{
    using System;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Shell page class.
    /// </summary>
    public sealed partial class ShellPage : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShellPage"/> class.
        /// </summary>
        public ShellPage()
        {
            this.InitializeComponent();
            this.shellNavigation.SelectionChanged += this.ShellNavigation_SelectionChanged;
            this.contentFrame.Navigate(typeof(Views.ChartPage));
        }

        /// <summary>
        /// Shell navigation selection changed event.
        /// </summary>
        /// <param name="sender">NavigationView.</param>
        /// <param name="args">NavigationViewSelectionChangedEventArgs.</param>
        private void ShellNavigation_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                this.contentFrame.Navigate(typeof(SettingsPage));
                return;
            }

            var selectedItem = args.SelectedItem as NavigationViewItem;

            if (!(selectedItem.Tag is Page))
            {
                //// TODO: add message ArgumentException("Tag must be a Page type.", nameof(args)) to resource.  Or log it and do nothing.
                throw new ArgumentNullException(nameof(args));
            }

            this.contentFrame.Navigate(selectedItem.Tag.GetType());
        }
    }
}