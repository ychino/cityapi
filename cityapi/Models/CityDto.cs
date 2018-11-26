﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cityapi.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPointsOfInterest
        { get
            {
                return PointsOfInterest.Count;
            }
        }
        public ICollection<PointOfInterestDTO> PointsOfInterest { get; set; }
        = new List<PointOfInterestDTO>();
    }
}
