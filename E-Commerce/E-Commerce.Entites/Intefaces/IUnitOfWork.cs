﻿using E_Commerce.Entites.Interfaces;

namespace E_Commerce.Entites.Intefaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepositry Categories {  get; }
        IProductRepositry Products { get; }
        int Complete();

        Task<int> CompleteAsync(); 
    }
}
