using ProductApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Application.DataTransferObject.Conversions
{
    public static class ProductConversion
    {
        public static Product ToEntity(ProductDataTransferObject product) => new()
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Quantity = product.Quantity
        };

        public static (ProductDataTransferObject?, IEnumerable<ProductDataTransferObject>?) FromEntity(Product product, IEnumerable<Product>? products)
        {
            // return single
            if (product is not null || products is null)
            {
                var singleProduct = new ProductDataTransferObject
                    (
                        product!.Id,
                        product.Name!,
                        product.Price,
                        product.Quantity
                    );
                return (singleProduct, null);
            }

            if (products is not null || product is null)
            {
                var _products = products!.Select(p =>
                    new ProductDataTransferObject
                    (
                        p.Id,
                        p.Name!,
                        p.Price,
                        p.Quantity
                    )).ToList();
                return (null, _products);
            }
            return (null, null);
        }
    }
}
