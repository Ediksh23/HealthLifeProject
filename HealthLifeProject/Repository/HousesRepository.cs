using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class HousesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public HousesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void Houses(int numbHouse, string descript)
        {
            _healthLifeDBContext.Houses.Add(new Houses() { numbHouse = numbHouse, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddHouse(Houses house)
        {
            _healthLifeDBContext.Add(house);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Houses> getAllHouses()
        {
            return _healthLifeDBContext.Houses.OrderBy(s => s.Id).ToList();
        }
    }
}
