﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : ICategoryDal
    {
        public void Add(Category product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category product)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category product)
        {
            throw new NotImplementedException();
        }

        Category IEntityRepository<Category>.Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
