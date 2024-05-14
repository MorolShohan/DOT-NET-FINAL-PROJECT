using System;

namespace BLL.DTOs
{
    public class StudentUpdateDTO
    {
        public string Name { get; set; }


        public DateTime? DateOfBirth { get; set; }


        public string Phone { get; set; }


        public string InstitutionName { get; set; }


        public string Address { get; set; }


        public string Password { get; set; }

        public string Gender { get; set; }
    }
}
