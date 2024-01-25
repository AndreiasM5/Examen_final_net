using Backend.Dto;
using Backend.Entity;

namespace Backend.Service;

public interface ProductService
{
    ProductDto AddProduct(ProductDto productDto);
    public List<Product> GetAllProducts();
    ProductDto GetProduct(int productId);
    void DeleteProduct(int productId);
    ProductDto UpdateProduct(int productId, ProductDto updatedProductDto);
    
}