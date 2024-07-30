using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class PositionsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public PositionsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void AddPositions(string name, string descript)
        {
            _healthLifeDBContext.Positions.Add(new Positions() { namePositions = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddPosition(Positions position)
        {
            _healthLifeDBContext.Add(position);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Positions> getAllPatronymics()
        {
            return _healthLifeDBContext.Positions.OrderBy(s => s.Id).ToList();
        }
    }
}
