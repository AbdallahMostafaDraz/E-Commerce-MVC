﻿using E_Commerce.DataAccess.Data;
using E_Commerce.Entites.Intefaces;
using E_Commerce.Entites.Models;

namespace E_Commerce.DataAccess.Repositries
{
    public class OrderHeaderRepositry : GenericRepositry<OrderHeader>, IOrderHeaderRepositry
    {
        public OrderHeaderRepositry(AppDBContext context) : base(context) { }

        public void UpdateOrderStatus(int orderId, string orderStatus, string paymentStatus)
        {
            var order = GetOne(e => e.Id ==  orderId);
            if (order != null)
            {
                order.OrderStatus = orderStatus;
                order.PaymentStatus = paymentStatus;
            }
            
        }
    }
}
