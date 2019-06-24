using NTMobileApp.Data.Entities;
using NTMobileApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.IRepositories
{
    public interface IProductCategoryRepository :IRepository<ProductCategory,int>
    {
    }
}
