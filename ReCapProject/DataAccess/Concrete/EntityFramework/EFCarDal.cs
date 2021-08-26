using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(RentACarContext context=new RentACarContext())
            {
                var result = from p in context.Car
                             join c in context.Color
                             on p.ColorId equals c.ColorId
                             join b in context.Brand
                             on p.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = p.Description,
                                 DailyPrice = p.DailyPrice,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName
                             };

                return result.ToList();
            }
        }
    }
}
