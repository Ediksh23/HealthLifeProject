using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class Patients
    { 
        public int Id { set; get; }
        public int SurnameID { set; get; }
        public int NameID { set; get; } //
        public int PatronymicID { set; get; }   //
        public List<PatientPhotos> PatientPhotos { set; get; }
        public DateTime birthDate { set; get; }
        public int GenderID { set; get; }
        public int CityID { set; get; }
        public int HospitalID { set; get; }
        public int WardID { set; get; }
        public int DiagnosisID { set; get; }
        public int CategoryID { set; get; }
        public int SubcategoryID { set; get; }
        public string Bank_account { set; get; }   // 
        public string Bank_card_number { set; get; }   //
        public int Fundraising_statusID { set; get; }
        public int Inn { set; get; }   //
        public int GiftedAmount { set; get; }
        public string Descript_patient_and_disease { set; get; }
        public string Notate { set; get; }

        public virtual Surnames Surname { set; get; }
        public virtual Names Name { set; get; }
        public virtual Patronymics Patronymic { set; get; }
        public virtual Category Category { set; get; }
        public virtual Subcategories Subcategory { set; get; }
        public virtual Gender Gender { set; get; }
        public virtual Cities City { set; get; }
        public virtual Hospitals Hospital { set; get; }
        public virtual Wards Ward { set; get; }
        public virtual FundraisingStatuses FundraisingStatus { set; get; }
    }
}