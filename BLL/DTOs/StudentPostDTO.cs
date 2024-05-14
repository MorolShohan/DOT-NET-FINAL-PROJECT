using System;

namespace BLL.DTOs
{
    public class StudentPostDTO
    {

        public int Id { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }


        public int PostedBy { get; set; }

        public DateTime Date { get; set; }


    }
}
