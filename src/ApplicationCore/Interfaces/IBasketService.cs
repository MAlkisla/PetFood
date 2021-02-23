﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBasketService
    {
        //returns basket items count
        Task<int> AddItemToBasketAsync(int basketId, int productId, decimal price, int quantity = 1);

        Task<bool> BasketExistsAsync(string buyerId);

        Task<int> CreateBasketAsync(string buyerId);

        Task<int> GetBasketIdAsync(string buyerId);
        Task<int> BasketItemsCount(string buyerId);
    }
}
