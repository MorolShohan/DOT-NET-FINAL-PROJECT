using System;

namespace BLL.DTOs
{
    public class StudentCourseDTO
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public string ShortDescription { get; set; }


        public string InstructorName { get; set; }


        public decimal Price { get; set; }


        public int Duration { get; set; }


        public string VideoPath { get; set; }


        public DateTime UploadTime { get; set; }


    }
}
