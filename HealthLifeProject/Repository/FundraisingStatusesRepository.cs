using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class FundraisingStatusesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public FundraisingStatusesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void FundraisingStatuses(string name, string descript)
        {
            _healthLifeDBContext.FundraisingStatuses.Add(new FundraisingStatuses() { nameFundraisingStatus = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddFundraisingStatus(FundraisingStatuses fundraisingStatus)
        {
            _healthLifeDBContext.Add(fundraisingStatus);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteFundraisingStatuseByID(int statuseID)
        {
            FundraisingStatuses fundraisingStatuse = _healthLifeDBContext.FundraisingStatuses.Find(statuseID);
            _healthLifeDBContext.FundraisingStatuses.Remove(fundraisingStatuse);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<FundraisingStatuses> getAllFundraisingStatuses()
        {
            return _healthLifeDBContext.FundraisingStatuses.OrderBy(s => s.Id).ToList();
        }
    }
}
