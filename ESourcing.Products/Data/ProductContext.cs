using ESourcing.Products.Data.Interface;
using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data
{
    public class ProductContext : IProductContext
    {
        public IMongoCollection<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
