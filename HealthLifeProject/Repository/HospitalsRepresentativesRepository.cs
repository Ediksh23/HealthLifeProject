using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class HospitalsRepresentativesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public HospitalsRepresentativesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddHospitalsRepresentative(HospitalsRepresentatives representative)
        {
            _healthLifeDBContext.Add(representative);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteHospitalsRepresentativeByID(int representativeID)
        {
            HospitalsRepresentatives representative = _healthLifeDBContext.HospitalsRepresentatives.Find(representativeID);
            _healthLifeDBContext.HospitalsRepresentatives.Remove(representative);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<HospitalsRepresentatives> getAllHospitalsRepresentatives()
        {
            return _healthLifeDBContext.HospitalsRepresentatives.OrderBy(s => s.Id).ToList();
        }

        public HospitalsRepresentatives GetHospitalsRepresentativeByEmail(string email)
        {
            HospitalsRepresentatives representative = _healthLifeDBContext.HospitalsRepresentatives.FirstOrDefault(u => u.Email == email);
            return representative;
        }
    }
}
