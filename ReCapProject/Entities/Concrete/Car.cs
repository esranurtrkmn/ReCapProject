﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // çıplak class kalmasın

    public class Car:IEntity
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public int ModelYear { get; set; }

        public double DailyPrice { get; set; }

        public String Description { get; set; }
    }
}