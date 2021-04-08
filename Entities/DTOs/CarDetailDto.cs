﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Descriptions { get; set; }
        public int ModelYear { get; set; }
        public int? MinFindexScore { get; set; }
        public string ImagePath { get; set; }


    }
}
