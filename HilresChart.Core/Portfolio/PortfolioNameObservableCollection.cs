// <copyright file="PortfolioNameObservableCollection.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Portfolio
{
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;

    /// <summary>
    /// Portfolio name observable collection class.
    /// Anytime there is a change to this collection, it will update the database.
    /// </summary>
    internal class PortfolioNameObservableCollection : ObservableCollection<PortfolioName>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioNameObservableCollection"/> class.
        /// </summary>
        internal PortfolioNameObservableCollection()
            : base()
        {
            this.LoadCollection();
        }

        /// <summary>
        /// Occurs when an item is added, removed, changed, moved, or the entire list is refreshed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">NotifyCollectionChangedEventArgs.</param>
        private void PortfolioNameObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    break;

                case NotifyCollectionChangedAction.Remove:
                    break;

                case NotifyCollectionChangedAction.Replace:
                    break;

                case NotifyCollectionChangedAction.Reset:
                    this.LoadCollection();
                    break;
            }
        }

        /// <summary>
        /// Load the collection.
        /// </summary>
        private void LoadCollection()
        {
            this.CollectionChanged -= this.PortfolioNameObservableCollection_CollectionChanged;
            this.Clear();

            this.Add(new PortfolioName() { Id = 1, Name = "Default" });
            this.Add(new PortfolioName() { Id = 2, Name = "Other" });

            this.CollectionChanged += this.PortfolioNameObservableCollection_CollectionChanged;
        }
    }
}