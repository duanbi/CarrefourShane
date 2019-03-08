using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrefourShane.Entities.DomainEntity;
using CarrefourShane.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarrefourShane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("productinfo")]
        public ProductInfoEntity GetProductInfo(int productId)
        {
            return _productService.GetProductInfo(productId);
        }

        [Route("productlist")]
        public List<ProductInfoEntity> GetProductList()
        {
            return _productService.GetProductList();
        }

        
    }
}