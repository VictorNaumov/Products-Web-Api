﻿using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class CartRepository : RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<Product>> GetCartProducts(ProductParameters productParameters, User user,
            bool trackChanges, double exchangeRate = default(double))
        {
            var products = await FindByCondition(c => c.User.UserName == user.UserName, trackChanges: false)
                .Select(c => c.Product)
                .Search(productParameters.SearchTerm)
                .FilterByProperties(productParameters)
                .IncludeFields()
                .Sort(productParameters.OrderBy)
                .ToListAsync();

            products?.ConvertCurrency(exchangeRate);
            var filteredProducts = products?.FilterByCurrency(productParameters);

            return PagedList<Product>
                .ToPagedList(filteredProducts, productParameters.PageNumber, productParameters.PageSize);
        }

        public void CreateCartProduct(Cart cart) =>
            Create(cart);

        public void DeleteCartProduct(Cart cart) =>
            Delete(cart);
    }
}
