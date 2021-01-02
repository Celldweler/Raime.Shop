﻿using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.CreateProducts 
{
    public class CreatePropuct
    {
        private ApplicationDbContext _context;

        public CreatePropuct(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task Do(ProductViewModel vm)
        {
            _context.Products.Add(new Domain.Models.Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Value = vm.Value,
            });

            await _context.SaveChangesAsync();
        }
    }
    
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
