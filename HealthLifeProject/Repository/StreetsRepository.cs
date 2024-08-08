using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class StreetsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public StreetsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void Streets(string name, string descript)
        {
            _healthLifeDBContext.Streets.Add(new Streets() { nameStreet = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddStreet(Streets street)
        {
            _healthLifeDBContext.Add(street);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteStreetByID(int streetID)
        {
            Streets street = _healthLifeDBContext.Streets.Find(streetID);
            _healthLifeDBContext.Streets.Remove(street);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Streets> getAllStreets()
        {
            return _healthLifeDBContext.Streets.OrderBy(s => s.Id).ToList();
        }
    }
}
