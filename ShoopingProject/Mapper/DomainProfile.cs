using AutoMapper;
using ShoopingProject.Models;
using ShoopingProject.Services.DTOs;
using ShoppingProject.Data.Entities;
using System.Collections.Generic;

namespace ShoopingProject.Mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<ProductCategory, ProductCategoryRequest>().ReverseMap();
            CreateMap<List<ProductCategoryModel>, List<ProductCategoryResponse>>().ReverseMap();
        }
    }
}
