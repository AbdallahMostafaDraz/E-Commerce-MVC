﻿using E_Commerce.Entites.Models;

namespace E_Commerce.Web.ViewModels.ShoppingCarts
{
    public class SummaryVM
    {
        public IEnumerable<ShoppingCart> ShoppingCarts { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
