using EPiServer.Core;
using Mediachase.Commerce;
using System.Collections.Generic;

namespace Foundation.Commerce.Order.ViewModels
{
    public class MiniCartViewModel
    {
        public ContentReference CheckoutPage { get; set; }

        public ContentReference CartPage { get; set; }

        public decimal ItemCount { get; set; }

        public IEnumerable<ShipmentViewModel> Shipments { get; set; }

        public Money Total { get; set; }

        public string Label { get; set; }

        public bool IsSharedCart { get; set; }
    }

    public class MiniWishlistViewModel
    {
        public ContentReference WishlistPage { get; set; }

        public decimal ItemCount { get; set; }

        public IEnumerable<CartItemViewModel> Items { get; set; }

        public Money Total { get; set; }

        public string Label { get; set; }

        public bool HasOrganization { get; set; }
    }

}