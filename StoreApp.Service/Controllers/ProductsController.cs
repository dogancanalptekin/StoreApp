﻿using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.Http;
using StoreApp.Data.Concrete.EntityFramework;
using StoreApp.Entity;

namespace StoreApp.Service.Controllers
{
    //Yalnızca bu controller a dışarıdan ulaşılmasını istediğimiz durumda
    //[EnableCors(origins: "http://localhost:50456", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        IProductRepository _productRepository;

        public ProductsController()
        {
            //dependency injection
            _productRepository = new EfProductRepository();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.Products;
        }

        public IEnumerable<Product> GetApprovedProducts()
        {
            return _productRepository.Products.Where(i => i.isApproved == true);
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = _productRepository.Products.Where(i => i.Id == id).FirstOrDefault();

            if (product == null)
            {
                return (IHttpActionResult) BadRequest("Ürün Bulunamadı.");
            }
            else
            {
                return Ok(product);
            }
        }

        //public Product GetProduct(int id)
        //{
        //    var product = _productRepository.Products.Where(i => i.Id == id).FirstOrDefault();

        //    if (product == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);
        //    }
        //    else
        //    {
        //        return product;
        //    }
        //}

        public async Task<IHttpActionResult> PostProduct(Product entity)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.SaveProductAsync(entity);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }
    }
}
