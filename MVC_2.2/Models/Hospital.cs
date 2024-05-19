using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_2._2.Models
{
    public class Hospital
    {
        public Hospital() 
        {
            Doctors = new List<Doctor>();
        }   
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhotoURL { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}