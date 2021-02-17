using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

            public InMemoryCarDal()
        {
            _cars = new List<Car> {
                 new Car {Id =1,BrandId=1,DailyPrice=300,ModelYear=2020,Description="Hatcback dizel" },
                 new Car {Id =2,BrandId=2,DailyPrice=400,ModelYear=2019,Description="Hatcback benzinli" },
                 new Car {Id =3,BrandId=2,DailyPrice=400,ModelYear=2018,Description="Transit dizel" },
                 new Car {Id =4,BrandId=3,DailyPrice=500,ModelYear=2019,Description="Station Vagoon benzinli" },
                 new Car {Id =5,BrandId=3,DailyPrice=500,ModelYear=2020,Description="Hatcback benzinli" },

             };   
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
