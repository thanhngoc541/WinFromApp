using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductByID(int Id);
        void InsertProduct(Product product);
        void DeleteProduct(int Id);
        void UpdateProduct(Product product);

    }
}
