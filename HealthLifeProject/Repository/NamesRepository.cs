using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class NamesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public NamesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void Names(string name, string descript)
        {
            _healthLifeDBContext.Names.Add(new Names() { name = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddName(Names name)
        {
            _healthLifeDBContext.Add(name);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteNameByID(int nameID)
        {
            Names name = _healthLifeDBContext.Names.Find(nameID);
            _healthLifeDBContext.Names.Remove(name);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<Names> getAllNames()
        {
            return _healthLifeDBContext.Names.OrderBy(s => s.Id).ToList();
        }
    }
}
