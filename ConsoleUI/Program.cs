﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var product in productManager.GetAllByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName+" UnitPrice:"+product.UnitPrice);
            }

            
        }
    }
}
