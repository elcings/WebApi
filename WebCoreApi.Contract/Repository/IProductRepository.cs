using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCoreApi.Domain.Entities.Catalog;

namespace WebCoreApi.Contract.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        Product GetById(Guid Id);
        bool RemoveProduct(Guid Id);
        ICollection<Product> GetAll();
    }
}
