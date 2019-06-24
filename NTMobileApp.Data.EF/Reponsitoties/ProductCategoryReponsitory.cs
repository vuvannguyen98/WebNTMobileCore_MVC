using NTMobileApp.Data.Entities;
using NTMobileApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.EF.Reponsitoties
{
    public class ProductCategoryReponsitory : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        
        public ProductCategoryReponsitory(AppDbContext context) : base(context)
        {
        }
    }
}
