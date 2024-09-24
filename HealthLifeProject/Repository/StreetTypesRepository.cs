using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class StreetTypesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public StreetTypesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void Streets(string name, string descript)
        {
            _healthLifeDBContext.Streets.Add(new Streets() { nameStreet = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddStreetType(StreetTypes streetType)
        {
            _healthLifeDBContext.Add(streetType);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteStreetTypeByID(int typeID)
        {
            StreetTypes type = _healthLifeDBContext.StreetTypes.Find(typeID);
            _healthLifeDBContext.StreetTypes.Remove(type);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Streets> getAllStreets()
        {
            return _healthLifeDBContext.Streets.OrderBy(s => s.Id).ToList();
        }
    }
}
