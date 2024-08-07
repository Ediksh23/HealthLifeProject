using System;
using System.Collections.Generic;

namespace HealthLifeProject.Entities { 
	public class Gender
	{
        public int Id { set; get; }
        public string NameGender { set; get; }
        public string Desc { set; get; }
        public List<Patients> Patients { set; get; }
    }
}