using AutoMapper;
using NTMobileApp.Application.ViewModels.Product;
using NTMobileApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            

        }
    }
}
