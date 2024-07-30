using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities
{
    public class ContactPhones
    {
        public int Id { set; get; }
        public string Number { set; get; }
        public string Desc { set; get; }
        public int HospitalsRepresentativeID { set; get; }
        public virtual HospitalsRepresentatives HospitalsRepresentative { set; get; }
    }
}
