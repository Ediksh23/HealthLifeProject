using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class DirectionOfHelpRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public DirectionOfHelpRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }
        //        internal void Category(string name, string descript)
        //        {
        //            _healthLifeDBContext.Category.Add(new Category() { NameCategory = name, Desc = descript });
        //            _healthLifeDBContext.SaveChanges();
        //        }
        public bool AddDirectionOfHelp(DirectionOfHelp direction)
        {
            _healthLifeDBContext.Add(direction);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<DirectionOfHelp> getAllDirectionOfHelp()
        {
            return _healthLifeDBContext.DirectionOfHelp.OrderBy(s => s.Id).ToList();
        }
    }
}
