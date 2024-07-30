using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class RolesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public RolesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void AddRoles(string name, string descript)
        {
            _healthLifeDBContext.Roles.Add(new Roles() { nameRole = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/
        public bool AddRole(Roles role)
        {
            _healthLifeDBContext.Add(role);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Roles> getAllRoles()
        {
            return _healthLifeDBContext.Roles.OrderBy(s => s.Id).ToList();
        }
    }
}
