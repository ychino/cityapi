using cityapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cityapi
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // seed data
            var cities = new List<City>()
            {
                new City(){
                    Name = "New York",
                    Description = "The one with the big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest() {
                            Name = "Central Park",
                            Description = "The most visited urban Park in the US"
                        },
                        new PointOfInterest() {
                            Name = "Empire State Building",
                            Description = "A 102 story building"
                        }
                    }
                },
                new City(){
                    Name = "Paris",
                    Description = "The one with the big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest() {
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars in Paris"
                        }
                    }
                },
                new City(){
                    Name = "Tokyo",
                    Description = "The one with people speak Japanese.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest() {
                            Name = "Tokyo Tower",
                            Description = "A tower in Tokyo"
                        }
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
