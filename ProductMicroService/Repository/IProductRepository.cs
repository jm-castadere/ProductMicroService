using ProductMicroservice.Models;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{

    /// <summary>
    /// Repository works as a micro component of microservice that encapsulates the data access layer
    /// </summary>
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int product);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void Save();
    }
}
