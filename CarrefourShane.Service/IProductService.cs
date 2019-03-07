using CarrefourShane.Entities.DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarrefourShane.Service
{
    public interface IProductService
    {

        ProductInfoEntity GetProductInfo(int productId);

        List<ProductInfoEntity> GetProductList();
    }
}
