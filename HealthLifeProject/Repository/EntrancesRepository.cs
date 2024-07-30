using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class EntrancesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public EntrancesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void AddEntrances(string name, string descript)
        {
            _healthLifeDBContext.Entrances.Add(new Entrances() { nameEntrance= name, desc= descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddEntrance(Benefactors entrance)
        {
            _healthLifeDBContext.Add(entrance);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
