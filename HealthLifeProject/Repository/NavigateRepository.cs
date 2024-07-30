using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLifeProject.Repository
{
    public class NavigateRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public NavigateRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public IQueryable<NavagateLink> GetAllNavagateLinks()
        {
            return _healthLifeDBContext.Navagates.OrderBy(n => n.Order);
        }

        //формируем навигационное дерево - должно содержать все элементы по всей вложенности
        public IEnumerable<NavagateLink> GetNavagatesThree()
        {
            IEnumerable<NavagateLink> threeRoots = _healthLifeDBContext.Navagates.Where(n => n.ParentId == null).OrderBy(n => n.Order).ToList();
            return threeRoots;
        }
    }
}
