using System;

namespace BLL.DTOs
{
    public class StudentCommentDTO
    {
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]

        public string CommentedBy { get; set; }
        [Required]

        public int PostId { get; set; }


    }
}
