using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

            new Car{ BrandId=1, ColorId=1, Id=1, DailyPrice=200, Description="Ford Fiesta ", ModelYear=2000},
            new Car{ BrandId=1, ColorId=2, Id=2, DailyPrice=200, Description="Ford Fiesta ", ModelYear=2005},
            new Car{ BrandId=2, ColorId=1, Id=3, DailyPrice=250, Description="Citröen ", ModelYear=2015},
            new Car{ BrandId=2, ColorId=2, Id=4, DailyPrice=300, Description="Citröen XL1400", ModelYear=2020}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
           _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

       
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
