using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal :IEntityRepository<Car>
    {
    
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);

        List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null);
    }
}
