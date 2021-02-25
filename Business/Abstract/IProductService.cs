using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();// List<Product> dan farkı hem listeyi hemde mesajı döndürür.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int prdouctId);
        IResult Add(Product product);// void bir işlem olduğu için IResult kullandık. void yani geriye birşey döndürmüyor.
        IResult Update(Product product);
    }
}
