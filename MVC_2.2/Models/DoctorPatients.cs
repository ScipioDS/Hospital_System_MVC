using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_2._2.Models
{
    public class DoctorPatients
    {
        public DoctorPatients() 
        {
            Patients = new List<Patient>();
        } 
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patient> Patients { get; set; }
    }
}