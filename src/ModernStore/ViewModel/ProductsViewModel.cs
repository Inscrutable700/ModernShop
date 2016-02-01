namespace ModernStore.ViewModel
{
    /// <summary>
    /// The products view model.
    /// </summary>
    public class ProductsViewModel
    {
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        public ProductItem[] Products { get; set; }

        /// <summary>
        /// The product item view model.
        /// </summary>
        public class ProductItem
        {
            /// <summary>
            /// Gets or sets the identifier.
            /// </summary>
            public int ID { get; set; }

            /// <summary>
            /// Gets or sets the title.
            /// </summary>
            public string Title { get; set; }
        }
    }
}
