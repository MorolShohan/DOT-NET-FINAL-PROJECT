using System;

namespace BLL.DTOs
{
    public class CourseDTO
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public string ShortDescription { get; set; }


        public string InstructorName { get; set; }



        public int Price { get; set; }



        public int Duration { get; set; }


        public string VideoPath { get; set; }


        public DateTime UploadTime { get; set; }


        public bool ApproveOrNot { get; set; }


        public int SellCount { get; set; }
        public int userId { get; set; }
    }
}
