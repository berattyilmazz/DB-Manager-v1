using System;
using System.Collections.Generic;
using System.Text;

namespace v1
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
