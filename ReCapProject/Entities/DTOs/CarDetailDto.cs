using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto: IDto
    {
        public String CarName { get; set; }

        public String BrandName { get; set; }

        public String ColorName { get; set; }

        public decimal DailyPrice { get; set; }
    }
}
