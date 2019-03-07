using CarrefourShane.Entities.DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarrefourShane.Service
{
    public class ProductService: IProductService
    {

        public ProductInfoEntity GetProductInfo(int productId)
        {
            return new ProductInfoEntity()
            {
                ProductId = productId,
                ProductName = "测试",
                ProductNumber = "1001001100"
            };
        }
    }
}
