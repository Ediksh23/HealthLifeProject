using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class ContactPhonesRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;
        public ContactPhonesRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddContactPhone(ContactPhones phone)
        {
            _healthLifeDBContext.Add(phone);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteContactPhoneByID(int phoneID)
        {
            ContactPhones contactPhone = _healthLifeDBContext.ContactPhones.Find(phoneID);
            _healthLifeDBContext.ContactPhones.Remove(contactPhone);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public List<ContactPhones> getAllContactPhones()
        {
            return _healthLifeDBContext.ContactPhones.OrderBy(s => s.Id).ToList();
        }
    }
}
