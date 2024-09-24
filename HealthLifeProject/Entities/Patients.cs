using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class Patients
    { 
        public int Id { set; get; }
        [ForeignKey("Surnames")]
        public int SurnameID { set; get; }
        [ForeignKey("Names")]
        public int NameID { set; get; }//
        [ForeignKey("Patronymics")]
        public int PatronymicID { set; get; }   //
        public List<PatientPhotos> PatientPhotos { set; get; }
        public DateTime BirthDate { set; get; }
        [ForeignKey("Gender")]
        public int GenderID { set; get; }
        [ForeignKey("Cities")]
        public int CityID { set; get; }
        [ForeignKey("Hospitals")]
        public int HospitalID { set; get; }
        [ForeignKey("Wards")]
        public int? WardID { set; get; } = null;
        [ForeignKey("Diagnoses")]
        public int DiagnosisID { set; get; }
        [ForeignKey("Category")]
        public int CategoryID { set; get; }
        [ForeignKey("TreatmentCategory")]
        public int TreatmentCategoryID { set; get; }
        public int FeeAmount { set; get; }
        public int DonationAmount { set; get; }

        public string Bank_account { set; get; }   // 
        public string Bank_card_number { set; get; }   //
        [ForeignKey("FundraisingStatuses")]
        public int FundraisingStatusID { set; get; }
        public string Inn { set; get; }   //
        public string Descript_patient_and_disease { set; get; }
        public string Notate { set; get; }

        public virtual Surnames Surname { set; get; }
        public virtual Names Name { set; get; }
        public virtual Patronymics Patronymic { set; get; }
        public virtual Category Category { set; get; }
        public virtual TreatmentCategory TreatmentCategory { set; get; }
        public virtual Gender Gender { set; get; }
        public virtual Cities City { set; get; }
        public virtual Hospitals Hospital { set; get; }
        public virtual Wards Ward { set; get; }
        public virtual FundraisingStatuses FundraisingStatus { set; get; }
    }
}