using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class PartnersRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public PartnersRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddPartner(Partners partner)
        {
            _healthLifeDBContext.Add(partner);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeletePartnerByID(int partnerID)
        {
            Partners partner = _healthLifeDBContext.Partners.Find(partnerID);
            _healthLifeDBContext.Partners.Remove(partner);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<Partners> getAllPartners()
        {
            return _healthLifeDBContext.Partners.OrderBy(s => s.Id).ToList();
        }
    }
}
