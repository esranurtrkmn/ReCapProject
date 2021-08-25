using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
           /* _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=2 , ColorId=3, DailyPrice=50000, Description="honda yeni", ModelYear=2010 },
                new Car{CarId=1, BrandId=2 , ColorId=3, DailyPrice=50000, Description="eski model", ModelYear=2000 },
                new Car{CarId=1, BrandId=2 , ColorId=3, DailyPrice=50000, Description="yeni araba", ModelYear=2019 }
            };*/
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            // car nesnesini direkt silemeyiz çünkü referans tip, dolayısıyla
            // gönderdiğim car id sine sahip olan listedeki car ı bul ve sil

            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        /*public List<Car> GetAllByColor(int ColorId)
        {
            return _cars.Where(p => p.ColorId == ColorId).ToList();
        }
        */
        public void Update(Car car)
        {
            //gönderdiğim car id sine sahip olan listedeki car ı bul.
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            /*carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;*/
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
