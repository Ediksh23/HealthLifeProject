using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class WardsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public WardsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        /*internal void Wards(string nameWard, int hospitalID, int cityID, int streetID, int entranceID, int houseID, string desc)
        {
            _healthLifeDBContext.Wards.Add(new Wards() { nameWard = nameWard, hospitalID= hospitalID, cityID = cityID, streetID = streetID, entranceID = entranceID, houseID = houseID, desc = desc });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddWard(Wards ward)
        {
            _healthLifeDBContext.Add(ward);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<Wards> GetAllWards()
        {
            return _healthLifeDBContext.Wards.OrderBy(o => o.Id).ToList();
        }

        public IEnumerable<Wards> GetHospitalsByHospitalID(int hospitalID)
        {
            return _healthLifeDBContext.Wards.Where(o => o.HospitalID == hospitalID).ToList();
        }
        public IEnumerable<Wards> GetHospitalsByCityID(int cityID)
        {
            return _healthLifeDBContext.Wards.Where(o => o.CityID == cityID).ToList();
        }
    }
}
