using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications
{
    public class ProductsFilterPaginatedSpecification : Specification<Product>
    {
        public ProductsFilterPaginatedSpecification(int? categoryId, int? brandId) : base()
        {
            Query.Where(x => (!categoryId.HasValue || x.CategoryId == categoryId) && (!brandId.HasValue || x.BrandId == brandId));
        }
    }
}
