using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class CitiesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public CitiesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        //       internal void Citi(string name, string descript)
        //        {
        //        _healthLifeDBContext.Cities.Add(new Cities() { nameCity = name, desc = descript });
        //        _healthLifeDBContext.SaveChanges();
        //        }

        public bool AddCity(Benefactors city)
        {
            _healthLifeDBContext.Add(city);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Cities> getAllCities()
        {
            return _healthLifeDBContext.Cities.OrderBy(s => s.Id).ToList();
        }
    }
}
