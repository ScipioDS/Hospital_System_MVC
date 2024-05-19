using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_2._2.Models
{
    public class Patient
    {
        public Patient() 
        {
            Doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}