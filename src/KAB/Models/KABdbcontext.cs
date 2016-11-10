using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KAB.Models.Entities
{
    public partial class KABdbcontext
    {
        public CategoryVM GetCategory(string name)
        {
            var category = this.Categories
                .Include(c => c.CategoriesProducts)
                .ThenInclude(p => p.Product)
                .FirstOrDefault(c => c.Name == name);
            var categoryVM = new CategoryVM();
            categoryVM.CategoryName = category.Name;

            var categoryProducts = category.CategoriesProducts.Select(p => p.Product).ToList();

            List<ProductVM> categoryProductsVM = new List<ProductVM>();
            foreach(var product in categoryProducts)
            {
                categoryProductsVM.Add(new ProductVM { Name = product.Name, Id = product.Id, Description = product.Description, ImageUrl = product.ImageUrl, Price = (double)product.Price });
            }

            categoryVM.Products  = categoryProductsVM;
            return categoryVM;
        }

        public ProductVM GetProduct(int id)
        {
            var product = this.Product.FirstOrDefault(p => p.Id == id);
            return Mapper.Map<ProductVM>(product);
        }
    }
}
