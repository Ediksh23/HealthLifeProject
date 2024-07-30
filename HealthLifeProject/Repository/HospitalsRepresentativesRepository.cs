using HealthLifeProject.Commons;
using HealthLifeProject.Entities;

namespace HealthLifeProject.Repository
{
    public class HospitalsRepresentativesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public HospitalsRepresentativesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        public bool AddHospitalsRepresentative(Hospitals representative)
        {
            _healthLifeDBContext.Add(representative);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
    
}
