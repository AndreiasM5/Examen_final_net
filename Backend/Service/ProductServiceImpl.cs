using Backend.Dao;
using Backend.Dto;
using Backend.Entity;
using Microsoft.EntityFrameworkCore;

namespace Backend.Service;

public class ProductServiceImpl : ProductService
{
    private readonly ApplicationDao _applicationDao;

    public ProductServiceImpl(ApplicationDao applicationDao)
    {
        _applicationDao = applicationDao;
    }

    public List<Product> GetAllProducts()
    {
        List<Product> products = _applicationDao.Products.ToList();

        return products;
    }

    public ProductDto GetProduct(int productId)
    {   
        Product product = _applicationDao.Products
        .FirstOrDefault(p => p.ProductId == productId);

        if (product == null) {
            throw new KeyNotFoundException("product with specified id doesn't exist");
        }
        
        ProductDto productDto = new ProductDto
        {
            ProductId = product.ProductId,
            Name = product.Name,
            Price = product.Price
        };

        return productDto;
    }
    public ProductDto AddProduct(ProductDto productDto)
    {   
        Product product = new Product
        {
            Name = productDto.Name,
            Price = productDto.Price
        };

        _applicationDao.Products.Add(product);
        _applicationDao.SaveChanges();

        productDto.ProductId = product.ProductId;
        return productDto;
    }

    public void DeleteProduct(int productId) 
    {

        Product product = _applicationDao.Products
        .FirstOrDefault(p => p.ProductId == productId);

        if (product == null) {
            throw new Exception();
        }
        
        _applicationDao.Products.Remove(product);
        _applicationDao.SaveChanges();
        
    }

    public ProductDto UpdateProduct(int productId, ProductDto updatedProductDto)
    {

    Product existingProduct = _applicationDao.Products
        .FirstOrDefault(p => p.ProductId == productId);


    if (existingProduct == null)
    {
        throw new Exception("Product not found");
    }


    existingProduct.Name = updatedProductDto.Name;
    existingProduct.Price = updatedProductDto.Price;


    _applicationDao.SaveChanges();


    updatedProductDto = new ProductDto
    {
        ProductId = existingProduct.ProductId,
        Name = existingProduct.Name,
        Price = existingProduct.Price
    };

    return updatedProductDto;
    }


}