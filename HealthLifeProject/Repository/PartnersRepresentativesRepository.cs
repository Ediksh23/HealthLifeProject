using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class PartnersRepresentativesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public PartnersRepresentativesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddPartnersRepresentative(PartnersRepresentatives representative)
        {
            _healthLifeDBContext.Add(representative);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeletePartnersRepresentativeByID(int representativeID)
        {
            PartnersRepresentatives representative = _healthLifeDBContext.PartnersRepresentatives.Find(representativeID);
            _healthLifeDBContext.PartnersRepresentatives.Remove(representative);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<PartnersRepresentatives> getAllPartnersRepresentatives()
        {
            return _healthLifeDBContext.PartnersRepresentatives.OrderBy(s => s.Id).ToList();
        }

        public PartnersRepresentatives GetPartnersRepresentativeByEmail(string email)
        {
            PartnersRepresentatives representative = _healthLifeDBContext.PartnersRepresentatives.FirstOrDefault(u => u.Email == email);
            return representative;
        }
    }
}
