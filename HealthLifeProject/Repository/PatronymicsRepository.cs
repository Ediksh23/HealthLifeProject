using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class PatronymicsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public PatronymicsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        /*internal void AddPatronymics(string name, string descript)
        {
            _healthLifeDBContext.Patronymics.Add(new Patronymics() { patronymic = name, desc = descript });
            _healthLifeDBContext.SaveChanges();
        }*/

        public bool AddPatronymic(Patronymics patronymic)
        {
            _healthLifeDBContext.Add(patronymic);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public List<Patronymics> getAllPatronymics()
        {
            return _healthLifeDBContext.Patronymics.OrderBy(s => s.Id).ToList();
        }
    }
}
