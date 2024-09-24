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

        /*internal void Entrances(string name, string descript)
        {
            _healthLifeDBContext.Entrances.Add(new Entrances() { nameEntrance= name, desc= descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddEntrance(Entrances entrance)
        {
            _healthLifeDBContext.Add(entrance);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteEntranceByID(int entranceID)
        {
            Entrances entrance = _healthLifeDBContext.Entrances.Find(entranceID);
            _healthLifeDBContext.Entrances.Remove(entrance);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
    }
}
