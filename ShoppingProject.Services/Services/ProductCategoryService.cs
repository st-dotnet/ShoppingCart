using AutoMapper;
using ShoopingProject.Services.DTOs;
using ShoppingProject.Data;
using ShoppingProject.Data.Entities;
using ShoppingProject.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingProject.Services.Services
{
    public class ProductCategoryService: IProductCategory
    {
        #region Constructor

        private readonly ShoppingDbContext _context;
        private readonly IMapper _mapper;
        public ProductCategoryService(ShoppingDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #endregion

        #region Public methods
        
        /// <summary>
        /// Add product category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public bool AddProductCategory(ProductCategoryRequest request)
        {
            try
            {
                //map ProductCategory entity with ProductCategoryRequest
                var data = _mapper.Map<ProductCategory>(request);
                //Save product category
                 _context.ProductCategories.Add(data);
                _context.SaveChanges();
                return true;
            }//try
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }//catch
        }

        /// <summary>
        /// Delete product category by category id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool DeleteProductCategory(int categoryId)
        {
            try
            {
                //get product category by caregory id
                var productCategory = _context.ProductCategories.Where(x => x.Id == categoryId).FirstOrDefault();
               
                //check if the product category is exists
                if (productCategory == null)
                    throw new NullReferenceException();

                //remove product category
                _context.ProductCategories.Remove(productCategory);
                return true;
            }//try
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }//catch
        }

        /// <summary>
        /// Get all product categories
        /// </summary>
        /// <returns></returns>
        public List<ProductCategoryResponse> GetProductCategories()
        {
            try
            {
                //get all product categories
                var result= _context.ProductCategories.ToList();
                return _mapper.Map<List<ProductCategoryResponse>>(result);
            }//try
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }//catch
        }

        /// <summary>
        /// Get product category by category id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public ProductCategoryResponse GetProductCategoryById(int categoryId)
        {
            try
            {
                //get product category by ID
                var result = _context.ProductCategories.Where(x => x.Id == categoryId).FirstOrDefault();

                //check if product category is exusts
                if (result == null)
                    throw new NullReferenceException();

                return _mapper.Map<ProductCategoryResponse>(result);
            }//try
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }//catch
        }

        /// <summary>
        /// Update product category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public bool UpdateProductCategory(ProductCategoryRequest request)
        {
            try
            {
                //Map ProductCategory entity with ProductCategoryRequest
                var data = _mapper.Map<ProductCategory>(request);

                //update Product category
                _context.ProductCategories.Update(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
