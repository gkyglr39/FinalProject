﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategory(int id);

        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
         
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product product);

        IDataResult<Product> GetById(int productId);

    }
}
