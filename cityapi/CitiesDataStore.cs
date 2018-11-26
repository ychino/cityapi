using cityapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cityapi
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto(){
                    Id = 1,
                    Name = "New York",
                    Description = "The one with the big park.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO() {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban Park in the US"
                        },
                        new PointOfInterestDTO() {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102 story building"
                        }
                    }
                },
                new CityDto(){
                    Id = 2,
                    Name = "Paris",
                    Description = "The one with the big tower.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO() {
                            Id = 1,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars in Paris"
                        }
                    }
                },
                new CityDto(){
                    Id = 3,
                    Name = "Tokyo",
                    Description = "The one with people speak Japanese.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO() {
                            Id = 1,
                            Name = "Tokyo Tower",
                            Description = "A tower in Tokyo"
                        }
                    }
                }
            };
        }
    }
}
