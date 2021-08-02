using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int catogoryId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCatogory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
