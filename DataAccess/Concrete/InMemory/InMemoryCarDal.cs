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
              new Car{Id=1, BrandId="opel", ColorId= "siyah", DailyPrice=300, Description="...", ModelId=1999},
              new Car{Id=2, BrandId="BMW", ColorId= "mavi", DailyPrice=900, Description="...", ModelId=1998},
              new Car{Id=3, BrandId="Renault", ColorId= "yeşil", DailyPrice=100, Description="...", ModelId=2005},
              new Car{Id=4, BrandId="Toyota", ColorId= "beyaz", DailyPrice=350, Description="...", ModelId=2008}
            };


        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =  _cars.SingleOrDefault(c=>c.Id ==car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        //public void GetById(Car car)
        //{
        //    return _cars.Where(c => c.)
        //}

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

        }
    }
}
