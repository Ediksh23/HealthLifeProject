﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace HealthLifeProject.Entities { 
    public class Hospitals
    {
        public int Id { set; get; }
        public string NameHospital { set; get; }
        [ForeignKey("Cities")]
        public int CityID { set; get; }
        [ForeignKey("Streets")]
        public int StreetID { set; get; }
        [ForeignKey("Entrances")]
        public int EntranceID { set; get; }
        [ForeignKey("Houses")]
        public int HouseID { set; get; }
        public string Linc { set; get; }
        public int DonationAmount { set; get; }
        public string Desc { set; get; }

        public List<Wards> Wards { set; get; }
        public List<Patients> Patients { set; get; }
        public List<HospitalsRepresentatives> HospitalsRepresentatives { set; get; }
        public List<HospitalsCharitableContributions> CharitableContributions { set; get; }

        public virtual Cities City { set; get; }
        public virtual Streets Street { set; get; }
        public virtual Entrances Entrance { set; get; }
        public virtual Houses House { set; get; }
    }
}