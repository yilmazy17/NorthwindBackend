using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductMenager:IProductService
    {
        private IProductDal _productDal;

        public ProductMenager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int produtcId)
        {
            return _productDal.Get(p => p.ProductID == produtcId);
        }

        public List<Product> GetList()
        {
            return _productDal.getList().ToList();
        }

        public List<Product> GetListByCatogory(int categoryId)
        {
            return _productDal.getList(p => p.CategoryId == categoryId).ToList();
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
           _productDal.Delete(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
