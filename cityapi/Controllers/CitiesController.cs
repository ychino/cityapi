using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using cityapi.Models;
using cityapi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cityapi.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }
        
        [HttpGet()]
        public IActionResult GetCities()
        {
            var cityEntities = _cityInfoRepository.GetCities();

            var result = new List<CityWithoutPointsOfInterestDto>();

            var results = Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities);

            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {
            var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                var cityResult = Mapper.Map<CityDto>(city);

                return Ok(cityResult);
            }

            var cityWithoutPointOfInterestResult = Mapper.Map<CityWithoutPointsOfInterestDto>(city);

            return Ok(cityWithoutPointOfInterestResult);
        }
    }
}
