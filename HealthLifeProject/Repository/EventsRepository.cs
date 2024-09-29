using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class EventsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public EventsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddWard(Events events)
        {
            _healthLifeDBContext.Add(events);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteEventByID(int eventID)
        {
            Events events = _healthLifeDBContext.Event.Find(eventID);
            _healthLifeDBContext.Event.Remove(events);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public IEnumerable<Events> GetAllEvents()
        {
            return _healthLifeDBContext.Event.OrderBy(o => o.Id).ToList();
        }
    }
}
