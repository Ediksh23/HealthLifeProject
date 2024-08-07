using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class PartnersRepresentatives
    {
        public int Id { set; get; }
        public int SurnameID { set; get; }
        public int NameID { set; get; } //
        public int PatronymicID { set; get; }   //
        public string ContactPhone { set; get; }
        public string Email { set; get; }
        public DateTime BirthDate { set; get; }
        public int PartnerID { set; get; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public int RoleID { set; get; }
        public string Notate { set; get; }

        public virtual Surnames Surname { set; get; }
        public virtual Names Name { set; get; }
        public virtual Patronymics Patronymic { set; get; }
        public virtual Gender Gender { set; get; }
        public virtual Cities City { set; get; }
        public virtual Partners Partner { set; get; }
        public virtual Roles Role { set; get; }
    }
}