using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class HospitalsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public HospitalsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        /*internal void Hospitals(string nameHospital, int cityID, int streetID, int entranceID, int houseID,  string desc)
        {
            _healthLifeDBContext.Hospitals.Add(new Hospitals() { nameHospital= nameHospital, cityID= cityID, streetID= streetID, entranceID= entranceID, houseID= houseID, desc= desc });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddHospital(Hospitals hospital)
        {
            _healthLifeDBContext.Add(hospital);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<Hospitals> GetAllHospitals()
        {
            return _healthLifeDBContext.Hospitals.OrderBy(o => o.Id).ToList();
        }

        public IEnumerable<Hospitals> GetHospitalsByCityID(int cityID)
        {
            return _healthLifeDBContext.Hospitals.Where(o => o.CityID == cityID).ToList();
        }

    }
}
