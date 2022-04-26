﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMomery;
using System;


namespace ConsoleUI 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger(new EfProductDal());

            foreach (var product in productManeger.GetAll())
            {
                Console.WriteLine(product.ProductName);  
            }

        }
    }
}