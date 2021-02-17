using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentingCarContext>, ICarDal
    {
        public List<Car> GetAllByBrandId(int brandId)
        {
            using (RentingCarContext context = new RentingCarContext())
            {
                return context.Set<Car>().Where(p => p.BrandId == brandId).ToList();

                //return _products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        public List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentingCarContext context = new RentingCarContext())
            {
                var result = from c in filter==null ? context.tbl_Cars :context.tbl_Cars.Where(filter)
                             join b in context.tbl_Brands
                             on c.BrandId equals b.BrandId
                             join x in context.tbl_Colors
                             on c.ColorId equals x.ColorId
                             select new CarDetailsDto { BrandId = c.BrandId, BrandName = b.BrandName, ColorId = c.ColorId, ColorName = x.ColorName, DailyPrice = c.DailyPrice,ModelYear =c.ModelYear,Id=c.Id, Description = c.Description };

                foreach (var carDetailsDto in result)
                {
                    Console.WriteLine($"{carDetailsDto.BrandName}-------{carDetailsDto.ColorName}-------{carDetailsDto.DailyPrice}");
                }

                return result.ToList();         

            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (RentingCarContext context = new RentingCarContext())
            {
                return context.Set<Car>().Where(p => p.ColorId == colorId).ToList();

            }
        }
    }
}
