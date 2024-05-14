using System;

namespace BLL.DTOs
{
    public class MgsDTO
    {
        public int MgsId { get; set; }


        public int StudentId { get; set; }


        public int TeacherId { get; set; }
        // public DateTime DateOfMgs { get; set; }


        public string Message { get; set; }
        public string Reply { get; set; }
        public DateTime DateOfMgsReply { get; set; }
    }
}
