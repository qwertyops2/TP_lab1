using Magazine.Core.Models;
using Magazine.Core.Services;
using Magazine.WebApi.Data;
namespace Magazine.WebApi {

    public class ProductService : IProductService
    {
        private readonly DbInformation _information;
        public ProductService(DbInformation information)
        {
            _information = information;
        }

        public Product add(Product product)
        {
            try
            {
                product.Id = Guid.NewGuid();
                _information.Products.Add(product);
                _information.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при добавлении продукта: {ex.Message}", ex);
            }
        }

        public Product edit(Product product)
        {
            try
            {
                var prod = _information.Products.FirstOrDefault(ID => ID.Id == product.Id);
                if (prod == null)
                {
                    throw new Exception($"Продукт с ID = {product.Id} не найден");
                }

                prod.Definition = product.Definition;
                prod.Name = product.Name;
                prod.Price = product.Price;
                prod.Image = product.Image;

                _information.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при изменении продукта: {ex.Message}", ex);
            }
        }

        public Product remove(Guid id)
        {
            try
            {
                var product = _information.Products.FirstOrDefault(ID => ID.Id == id);
                if (product == null)
                {
                    throw new Exception($"Продукт с ID = {id} не найден");
                }

                _information.Products.Remove(product);
                _information.SaveChanges();
                return product;

            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при удалении продукта: {ex.Message}", ex);
            }
        }

        public Product? search(Guid id)
        {
            try
            {
                var product = _information.Products.FirstOrDefault(ID => ID.Id == id);
                if (product == null)
                {
                    throw new Exception($"Продукт с ID = {id} не найден");
                }
                return product;

            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при поиске продукта: {ex.Message}", ex);
            }
        }
    }

}
