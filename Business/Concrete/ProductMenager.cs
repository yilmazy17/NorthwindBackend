using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<Product> GetById(int produtcId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID == produtcId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.getList().ToList());
        }

        public IDataResult<List<Product>> GetListByCatogory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.getList(p => p.CategoryId == categoryId).ToList());
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
           _productDal.Delete(product);
           return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
