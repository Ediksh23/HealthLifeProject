using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class HospitalsRepresentatives
    {
        public int Id { set; get; }
        [ForeignKey("Surnames")]
        public int SurnameID { set; get; }
        [ForeignKey("Names")]
        public int NameID { set; get; }//
        [ForeignKey("Patronymics")]
        public int PatronymicID { set; get; }   //
        public string ContactPhone { set; get; }
        public string Email { set; get; }
        public DateTime BirthDate { set; get; }
        [ForeignKey("Gender")]
        public int GenderID { set; get; }
        [ForeignKey("Cities")]
        public int CityID { set; get; }
        [ForeignKey("Hospitals")]
        public int HospitalID { set; get; }
        [ForeignKey("Wards")]
        public int? WardID { set; get; } = null;
        [ForeignKey("Positions")]
        public int PositionID { set; get; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        [ForeignKey("Roles")]
        public int RoleID { set; get; }
        public string Notate { set; get; }

        public virtual Surnames Surname { set; get; }
        public virtual Names Name { set; get; }
        public virtual Patronymics Patronymic { set; get; }
        public virtual Gender Gender { set; get; }
        public virtual Cities City { set; get; }
        public virtual Hospitals Hospital { set; get; }
        public virtual Wards Ward { set; get; }
        public virtual Positions Position { set; get; }
        public virtual Roles Role { set; get; }
    }
}